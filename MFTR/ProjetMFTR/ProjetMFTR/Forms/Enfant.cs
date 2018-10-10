using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ProjetMFTR.DataAccess;
using ProjetMFTR.DbConnexion.Helper;
using ProjetMFTR.Resources;

namespace ProjetMFTR.Forms
{
	public partial class Enfant : Form
	{
		#region Members

		private Connexion.ConnexionActions<Entities.Enfants> connexionActions = new Connexion.ConnexionActions<Entities.Enfants>();
		private Entities.Enfants CurrentChild;
		private String CurrentDossierID;
		private Entities.Options options;

		#endregion Members

		#region Events

		public event EventHandler<Entities.Enfants> ChildAdded;

		#endregion Events

		public Enfant(string dossierID)
		{
			InitializeComponent();
			CurrentDossierID = dossierID;
			dtpNaissance.MaxDate = Helper.CurrentMaxDateTime();
			cboReferent.DataSource = Connexion.Instance().Referent.OrderBy((x) => x.Referent_ID).ToList();
			cboReferent.DisplayMember = ResourcesString.STR_ReferentId;
			cboReferent.ValueMember = ResourcesString.STR_ReferentId;
			cboReferent.SelectedValue = -1;

			options = Connexion.Instance().Options.FirstOrDefault();

			openFile.InitialDirectory = options.Path;
			openFile.Title = "Choisir une photo";
			openFile.CheckFileExists = true;
			openFile.CheckPathExists = true;
			openFile.Filter = "Photos PNG (*.png)|*.png|Photos JPG (*.jpg)|*.jpg|Tous (*.*)|*.*";
		}

		public Enfant(Entities.Enfants enfants) : this(enfants.Dossier_ID)
		{
			CurrentChild = enfants;
			AssignChild(CurrentChild);

			// Create the ToolTip and associate with the Form container.
			ToolTip toolTip1 = new ToolTip();

			// Set up the delays for the ToolTip.
			toolTip1.AutoPopDelay = 5000;
			toolTip1.InitialDelay = 1000;
			toolTip1.ReshowDelay = 500;
			// Force the ToolTip text to be displayed whether or not the form is active.
			toolTip1.ShowAlways = true;

			// Set up the ToolTip text for the Button and Checkbox.
			toolTip1.SetToolTip(this.pnlPicture, CurrentChild.Photo);
		}

		protected virtual void OnChildAdded(EventArgs e)
		{
			ChildAdded?.Invoke(this, CurrentChild);
		}

		private void AssignChild(Entities.Enfants enfants)
		{
			dtpNaissance.Value = enfants.Naissance.HasValue ? enfants.Naissance.Value : DateTime.Now;
			txtNom.Text = enfants.Nom;
			txtPrenom.Text = enfants.Prenom;
			var accueil = "";
			if (enfants.Accueil.HasValue)
			{
				accueil = enfants.Accueil.Value == true ? "Oui" : "Non";
			}
			cboStatut.Text = accueil;
			cboSexe.Text = enfants.Sexe;
			cboReferent.Text = enfants.Referent_ID;

			var title = "enf";
			var path = options.Path;
			var suffix = CurrentDossierID + " " + title + " " + CurrentChild.Prenom;
			var jpg = ".jpg";
			var png = ".png";
			var finalPath = Path.Combine(path, suffix);

			if (File.Exists(finalPath + jpg))
			{
				Bitmap bmp = new Bitmap(finalPath + jpg);

				pnlPicture.BackgroundImage = bmp;
				CurrentChild.Photo = finalPath + jpg;
			}
			else if (File.Exists(finalPath + png))
			{
				Bitmap bmp = new Bitmap(finalPath + png);

				pnlPicture.BackgroundImage = bmp;
				CurrentChild.Photo = finalPath + png;
			}
			else if (File.Exists(CurrentChild.Photo))
			{
				Bitmap bmp = new Bitmap(CurrentChild.Photo);

				pnlPicture.BackgroundImage = bmp;
			}

		}

		private void AssignValues()
		{
			CurrentChild.Dossier_ID = CurrentDossierID;
			CurrentChild.Naissance = this.dtpNaissance.Value.Date;
			CurrentChild.Nom = this.txtNom.Text;
			CurrentChild.Prenom = this.txtPrenom.Text;
			CurrentChild.Accueil = this.cboStatut.SelectedIndex == 1 ? false : true;
			CurrentChild.Sexe = this.cboSexe.SelectedItem.ToString();
			CurrentChild.Referent_ID = cboReferent.Text;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Save();
		}

		private void btnSaveAndClose_Click(object sender, EventArgs e)
		{
			Save();
			Close();
		}

		private Boolean Save()
		{
			DialogResult result;
			if (CurrentChild != null)
			{
				AssignValues();
				connexionActions.Update(CurrentChild);
				return true;
			}

			if (string.IsNullOrWhiteSpace(txtNom.Text))
			{
				MessageBox.Show("Vous devez définir un nom pour pouvoir ajouter l'enfant",
				"Attention",
				MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtPrenom.Text))
			{
				MessageBox.Show("Vous devez définir un prénom pour pouvoir ajouter l'enfant",
				"Attention",
				MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}

			CurrentChild = new Entities.Enfants();
			AssignValues();
			connexionActions.Add(CurrentChild);

			OnChildAdded(new EventArgs());
			return true;
		}

		private void pnlPicture_DoubleClick(object sender, EventArgs e)
		{
			if (openFile.ShowDialog() == DialogResult.OK)
			{
				var filename = openFile.FileName;
				CurrentChild.Photo = filename;

				Bitmap bmp = new Bitmap(CurrentChild.Photo);

				pnlPicture.BackgroundImage = bmp;
			}
		}
	}
}