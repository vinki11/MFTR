using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using ProjetMFTR.DataAccess;
using ProjetMFTR.DbConnexion.Helper;

namespace ProjetMFTR.Forms
{
	public partial class Parent : Form
	{
		#region Members

		private Entities.Adultes CurrentAdulte;
		private String CurrentDossierID;
		private Entities.Parent CurrentParent;
		private Entities.Options options;

		#endregion Members

		#region Events

		public event EventHandler<Entities.Parent> ParentAdded;

		#endregion Events

		public Parent(string dossierId)
		{
			InitializeComponent();
			CurrentDossierID = dossierId;
			dtpNaissance.MaxDate = Helper.CurrentMaxDateTime();
			gvPhone.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;

			this.SetStyle(
							ControlStyles.AllPaintingInWmPaint |
							ControlStyles.DoubleBuffer,
							true);

			options = Connexion.Instance().Options.FirstOrDefault();

			openFile.InitialDirectory = options.Path;
			openFile.Title = "Choisir une photo";
			openFile.CheckFileExists = true;
			openFile.CheckPathExists = true;
			openFile.Filter = "Photos PNG (*.png)|*.png|Photos JPG (*.jpg)|*.jpg|Tous (*.*)|*.*";
		}

		public Parent(Entities.Parent parent) : this(parent.Adultes.Dossier_ID)
		{
			Connexion.Instance().Entry(parent).Reload();
			CurrentParent = parent;
			CurrentAdulte = parent.Adultes;
			bsAdresse.DataSource = CurrentAdulte.Adresse.Any() ? CurrentAdulte.Adresse.FirstOrDefault() : new Entities.Adresse();
			bsTelephone.DataSource = Connexion.Instance().Telephone.Where(x => x.Adulte_ID == CurrentAdulte.Adulte_ID).ToList();
			var lienReferents = CurrentAdulte.Parent.Where(x => x.Adulte_ID == CurrentAdulte.Adulte_ID).SelectMany(o => o.LienReferrent).ToList();
			bsReferent.DataSource = Connexion.Instance().Referent.ToList().Where(x => lienReferents.Any(o => x.Referent_ID.Equals(o.Referent_ID))).ToList();
			init();
			AssignParent();


			// Create the ToolTip and associate with the Form container.
			ToolTip toolTip1 = new ToolTip();

			// Set up the delays for the ToolTip.
			toolTip1.AutoPopDelay = 5000;
			toolTip1.InitialDelay = 1000;
			toolTip1.ReshowDelay = 500;
			// Force the ToolTip text to be displayed whether or not the form is active.
			toolTip1.ShowAlways = true;

			// Set up the ToolTip text for the Button and Checkbox.
			toolTip1.SetToolTip(this.pnlPicture, CurrentParent.Photo);
		}

		public void init()
		{
			gvReferent.Columns["Nom"].DataPropertyName = "Adultes.Nom";
			gvReferent.Columns["Prenom"].DataPropertyName = "Adultes.Prenom";
		}

		protected virtual void OnParentAdded(EventArgs e)
		{
			ParentAdded?.Invoke(this, CurrentParent);
		}

		private void AddReferent()
		{
			if (CurrentParent == null) { return; }
			var bs = new BindingSource();
			bs = bsReferent;
			var referents = bs.List.OfType<Entities.Referent>().Where(x => x.Adulte_ID == null).ToList();

			foreach (var r in referents)
			{
				var referent = Connexion.Instance().Referent.FirstOrDefault(x => x.Referent_ID == r.Referent_ID);

				if (referent == null)
				{
					var adulte = new Entities.Adultes();
					adulte.Nom = r.Adultes.Nom;
					adulte.Prenom = r.Adultes.Prenom;
					Connexion.connexionActionsAdultes.Add(adulte);
					var refe = new Entities.Referent();
					refe.Adulte_ID = adulte.Adulte_ID;
					refe.Organisation = r.Organisation;
					refe.Type = r.Type;
					Connexion.connexionActionsReferents.Add(refe);
					//Connexion.connexionActionsReferents.ObjectContextUpdater();

					var lienReferent = new Entities.LienReferrent();
					lienReferent.Referent_ID = refe.Referent_ID;
					lienReferent.Parent_ID = CurrentParent.Parent_ID;
					Connexion.connexionActionsLienReferrent.Add(lienReferent);
				}
				else
				{
					var lienReferent = new Entities.LienReferrent();
					lienReferent.Referent_ID = referent.Referent_ID;
					lienReferent.Parent_ID = CurrentParent.Parent_ID;

					Connexion.connexionActionsLienReferrent.Add(lienReferent);
				}
				//Connexion.connexionActionsLienReferrent.ObjectContextUpdater();
			}
		}

		private void AssignAdresse(Entities.Adresse adresse)
		{
			adresse.Civic = txtNumero.Text;
			adresse.Rue = txtAdresse.Text;
			adresse.Unite = txtUnite.Text;
			adresse.Ville = txtTown.Text;
			adresse.Province = txtProvince.Text;
			adresse.CodePostal = txtPostalCode.Text;
			adresse.Pays = txtPays.Text;
		}

		private void AssignParent()
		{
			txtNom.Text = CurrentAdulte.Nom;
			txtPrenom.Text = CurrentAdulte.Prenom;
			rtxtRemarque.Text = CurrentAdulte.Note;

			dtpNaissance.Value = CurrentParent.Naissance.HasValue ? CurrentParent.Naissance.Value : DateTime.Now.Date;
			cboStatut.Text = CurrentParent.Statut;
			cboSexe.Text = CurrentParent.Sexe;

			var title = CurrentParent.Sexe == "Mère" || CurrentParent.Sexe == "Grand-Mère" ? "Mme" : "M";
			var path = options.Path;
			var suffix = CurrentDossierID + " " + title;
			var jpg = ".jpg";
			var png = ".png";
			var finalPath = Path.Combine(path, suffix);

			if (File.Exists(finalPath + jpg))
			{
				Bitmap bmp = new Bitmap(finalPath + jpg);

				pnlPicture.BackgroundImage = bmp;
				CurrentParent.Photo = finalPath + jpg;
			}
			else if (File.Exists(finalPath + png))
			{
				Bitmap bmp = new Bitmap(finalPath + png);

				pnlPicture.BackgroundImage = bmp;
				CurrentParent.Photo = finalPath + png;
			}
			else if (File.Exists(CurrentParent.Photo))
			{
				Bitmap bmp = new Bitmap(CurrentParent.Photo);

				pnlPicture.BackgroundImage = bmp;
			}
		}

		private void AssignValuesAdultes()
		{
			CurrentAdulte.Nom = txtNom.Text;
			CurrentAdulte.Prenom = txtPrenom.Text;
			CurrentAdulte.Note = rtxtRemarque.Text;
		}

		private void AssignValuesParent()
		{
			CurrentParent.Adultes = CurrentAdulte;
			CurrentParent.Adulte_ID = CurrentAdulte.Adulte_ID;
			CurrentParent.Naissance = this.dtpNaissance.Value.Date;
			CurrentParent.Statut = this.cboStatut.Text;
			CurrentParent.Sexe = this.cboSexe.Text;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Save();
			AddReferent();
		}

		private void btnSaveAndClose_Click(object sender, EventArgs e)
		{
			Save();
			Close();
		}

		private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if ((gvReferent.Rows[e.RowIndex].DataBoundItem != null) &&
		 (gvReferent.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
			{
				e.Value = Helper.BindProperty(
											gvReferent.Rows[e.RowIndex].DataBoundItem,
											gvReferent.Columns[e.ColumnIndex].DataPropertyName
										);
			}
		}

		private void gvPhone_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
		{
			e.ContextMenuStrip = ParentContextMenu;
		}

		private void gvPhone_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			//if (CurrentAdulte == null) { return; }
			//var telephone = (Entities.Telephone)bsTelephone.Current;

			//if (telephone == null)
			//{
			//	return;
			//}

			//if (telephone.Adulte_ID != null) { return; }

			//telephone.Adulte_ID = CurrentAdulte.Adulte_ID;
			//telephone.Adultes = CurrentAdulte;
			//connexionActionsPhone.Add(telephone);
		}

		private void gvReferent_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			//if (CurrentAdulte == null) { return; }
			var referent = (Entities.Referent)bsReferent.Current;

			if (referent == null) { return; }
			if (referent.Adulte_ID != null) { return; }

			var adulte = new Entities.Adultes();
			referent.Adultes = adulte;
			referent.Adultes.Nom = "";
			referent.Adultes.Prenom = "";

			init();
		}

		private void remove_phone_Click(object sender, EventArgs e)
		{
			DataGridViewRow row = gvPhone.CurrentRow;
			var telephone = (Entities.Telephone)row.DataBoundItem;

			if (telephone == null) { return; }
			if (!Connexion.Instance().Telephone.Any(x => x.Tel_ID == telephone.Tel_ID)) { return; }

			//if (Connexion.Instance().Entry(telephone).State == System.Data.Entity.EntityState.Detached)
			//{
			//	Connexion.Instance().Telephone.Attach(telephone);
			//}

			Connexion.Instance().Telephone.Remove(telephone);
			Connexion.Instance().SaveChanges();

			//Connexion.connexionActionsTelephone.ObjectContextUpdater();
			bsTelephone.DataSource = CurrentAdulte.Telephone.ToList();
		}

		private Boolean Save()
		{
			Entities.Adresse adresse;
			if (CurrentParent != null && CurrentAdulte != null)
			{
				AssignValuesParent();
				Connexion.connexionActionsParent.Update(CurrentParent);

				AssignValuesAdultes();
				Connexion.connexionActionsAdultes.Update(CurrentAdulte);
			}
			//foreach (var telephone in CurrentAdulte.Telephone)
			//{
			//	if (Connexion.Instance().Telephone.AsNoTracking().Any(x => x.Tel_ID == telephone.Tel_ID))
			//	{
			//		var tel = Connexion.Instance().Telephone.FirstOrDefault(x => x.Tel_ID == telephone.Tel_ID);

			//		tel.Telephone1 = telephone.Telephone1;
			//		tel.Type = telephone.Type;
			//		tel.Poste = telephone.Poste;
			//		tel.Precision = telephone.Precision;
			//		tel.Adulte_ID = telephone.Adulte_ID;

			//		if (Connexion.Instance().Entry(tel).State == System.Data.Entity.EntityState.Detached)
			//		{
			//			Connexion.Instance().Telephone.Attach(tel);
			//		}
			//		Connexion.connexionActionsTelephone.Update(tel);
			//	}
			//	else
			//	{
			//		Connexion.connexionActionsTelephone.Add(telephone);
			//	}
			//}

			//CurrentAdulte = Connexion.Instance().Adultes.FirstOrDefault(x => x.Adulte_ID == CurrentAdulte.Adulte_ID);
			//Connexion.Instance().Entry(CurrentAdulte).Reload();

			//AssignValuesAdultes();
			//Connexion.connexionActionsAdultes.Update(CurrentAdulte);
			//Connexion.connexionActionsAdultes.ObjectContextUpdater();

			var address = (Entities.Adresse)bsAdresse.Current;

			if (address != null && address.Adresse_ID != 0)
			{

				address = Connexion.Instance().Adresse.FirstOrDefault(x => x.Adresse_ID == address.Adresse_ID);

				AssignAdresse(address);

				address.Adulte_ID = CurrentAdulte.Adulte_ID;

				Connexion.connexionActionsAdresse.Update(address);
				//Connexion.connexionActionsAdresse.ObjectContextUpdater();

				bsAdresse.DataSource = address;

				return true;
			}
			else if (address != null)
			{
				address = new Entities.Adresse();
				AssignAdresse(address);

				address.Adulte_ID = CurrentAdulte?.Adulte_ID;

				Connexion.connexionActionsAdresse.Add(address);

				return true;
			}



			//Si nouveau Parent
			CurrentAdulte = new Entities.Adultes();
			CurrentParent = new Entities.Parent();
			adresse = new Entities.Adresse();

			AssignValuesAdultes();
			CurrentAdulte.Dossier_ID = CurrentDossierID;
			Connexion.connexionActionsAdultes.Add(CurrentAdulte);
			AssignValuesParent();

			AssignAdresse(adresse);
			adresse.Adulte_ID = CurrentAdulte.Adulte_ID;

			Connexion.connexionActionsParent.Add(CurrentParent);
			Connexion.connexionActionsAdresse.Add(adresse);

			OnParentAdded(new EventArgs());
			return true;
		}

		private void pnlPicture_Paint(object sender, PaintEventArgs e)
		{
			Bitmap backgroundImage = new Bitmap(CurrentParent.Photo);

			e.Graphics.DrawImage(
					backgroundImage,
					this.ClientRectangle,
					new Rectangle(0, 0, backgroundImage.Width, backgroundImage.Height),
					GraphicsUnit.Pixel);
		}

		private void pnlPicture_DoubleClick(object sender, EventArgs e)
		{
			if (openFile.ShowDialog() == DialogResult.OK)
			{

				var filename = openFile.FileName;
				CurrentParent.Photo = filename;

				Bitmap bmp = new Bitmap(CurrentParent.Photo);

				pnlPicture.BackgroundImage = bmp;
			}

		}

		private void add_phone_Click(object sender, EventArgs e)
		{
			ParentPhone p = new ParentPhone(CurrentAdulte);
			p.FormClosing += new FormClosingEventHandler(UpdateDataSource);
			p.Show();
		}

		private void UpdateDataSource(object sender, EventArgs e)
		{
			var telephones = Connexion.Instance().Telephone.Where(x => x.Adulte_ID == CurrentAdulte.Adulte_ID).ToList();

			bsTelephone.DataSource = telephones;
		}

		private void gvPhone_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = gvPhone.CurrentRow;
			if (row == null) { return; }

			ParentPhone p = new ParentPhone((Entities.Telephone)row.DataBoundItem);
			p.FormClosing += new FormClosingEventHandler(UpdateDataSource);
			p.Show();
		}
	}
}