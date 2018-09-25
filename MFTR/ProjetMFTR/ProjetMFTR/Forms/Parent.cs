﻿using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ProjetMFTR.DataAccess;
using ProjetMFTR.DbConnexion.Helper;

namespace ProjetMFTR.Forms
{
	public partial class Parent : Form
	{
		#region Members

		private Connexion.ConnexionActions<Entities.LienReferrent> connexionActionLienReferrent = new Connexion.ConnexionActions<Entities.LienReferrent>();
		private Connexion.ConnexionActions<Entities.Referent> connexionActionReferent = new Connexion.ConnexionActions<Entities.Referent>();
		private Connexion.ConnexionActions<Entities.Adresse> connexionActionsAdresse = new Connexion.ConnexionActions<Entities.Adresse>();
		private Connexion.ConnexionActions<Entities.Adultes> connexionActionsAdulte = new Connexion.ConnexionActions<Entities.Adultes>();
		private Connexion.ConnexionActions<Entities.Parent> connexionActionsParent = new Connexion.ConnexionActions<Entities.Parent>();
		private Connexion.ConnexionActions<Entities.Telephone> connexionActionsPhone = new Connexion.ConnexionActions<Entities.Telephone>();
		private Entities.Adultes CurrentAdulte;
		private String CurrentDossierID;
		private Entities.Parent CurrentParent;

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
		}

		public Parent(Entities.Parent parent) : this(parent.Adultes.Dossier_ID)
		{
			CurrentParent = parent;
			CurrentAdulte = parent.Adultes;
			bsAdresse.DataSource = CurrentAdulte.Adresse.Any() ? CurrentAdulte.Adresse.FirstOrDefault() : new Entities.Adresse();
			bsTelephone.DataSource = CurrentAdulte.Telephone.ToList();
			var lienReferents = CurrentAdulte.Parent.Where(x => x.Adulte_ID == CurrentAdulte.Adulte_ID).SelectMany(o => o.LienReferrent).ToList();
			bsReferent.DataSource = Connexion.Instance().Referent.ToList().Where(x => lienReferents.Any(o => x.Referent_ID.Equals(o.Referent_ID))).ToList();
			init();
			AssignParent();
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
					connexionActionsAdulte.Add(adulte);
					var refe = new Entities.Referent();
					refe.Adulte_ID = adulte.Adulte_ID;
					refe.Organisation = r.Organisation;
					refe.Type = r.Type;
					connexionActionReferent.Add(refe);
					var lienReferent = new Entities.LienReferrent();
					lienReferent.Referent_ID = refe.Referent_ID;
					lienReferent.Parent_ID = CurrentParent.Parent_ID;
					connexionActionLienReferrent.Add(lienReferent);
				}
				else
				{
					var lienReferent = new Entities.LienReferrent();
					lienReferent.Referent_ID = referent.Referent_ID;
					lienReferent.Parent_ID = CurrentParent.Parent_ID;

					connexionActionLienReferrent.Add(lienReferent);
				}
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

			dtpNaissance.Value = CurrentParent.Naissance.HasValue ? CurrentParent.Naissance.Value : DateTime.Now.Date;
			cboStatut.Text = CurrentParent.Statut;
			cboSexe.Text = CurrentParent.Sexe;
		}

		private void AssignValuesAdultes()
		{
			CurrentAdulte.Dossier_ID = CurrentDossierID;
			CurrentAdulte.Nom = txtNom.Text;
			CurrentAdulte.Prenom = txtPrenom.Text;
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
			if (CurrentAdulte == null) { return; }
			var telephone = (Entities.Telephone)bsTelephone.Current;

			if (telephone == null) { return; }
			if (telephone.Adulte_ID != null) { return; }

			telephone.Adulte_ID = CurrentAdulte.Adulte_ID;
			telephone.Adultes = CurrentAdulte;
			connexionActionsPhone.Add(telephone);
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
			if (!Connexion.Instance().Telephone.Any(x => x.Tel_ID == ((Entities.Telephone)row.DataBoundItem).Tel_ID)) { return; }

			Connexion.Instance().Telephone.Remove((Entities.Telephone)row.DataBoundItem);
			Connexion.Instance().SaveChanges();

			bsTelephone.DataSource = CurrentAdulte.Telephone.ToList();
		}

		private Boolean Save()
		{
			Entities.Adresse adresse;
			if (CurrentParent != null && CurrentAdulte != null)
			{
				AssignValuesAdultes();
				AssignValuesParent();
				connexionActionsParent.Update(CurrentParent);
				connexionActionsAdulte.Update(CurrentAdulte);

				if (!CurrentAdulte.Adresse.Any())
				{
					adresse = new Entities.Adresse();
					AssignAdresse(adresse);
					adresse.Adulte_ID = CurrentAdulte.Adulte_ID;

					connexionActionsAdresse.Add(adresse);
				}
				return true;
			}

			//Si nouveau Parent
			CurrentAdulte = new Entities.Adultes();
			CurrentParent = new Entities.Parent();
			adresse = new Entities.Adresse();

			AssignValuesAdultes();
			connexionActionsAdulte.Add(CurrentAdulte);
			AssignValuesParent();

			AssignAdresse(adresse);
			adresse.Adulte_ID = CurrentAdulte.Adulte_ID;

			connexionActionsParent.Add(CurrentParent);
			connexionActionsAdresse.Add(adresse);

			OnParentAdded(new EventArgs());
			return true;
		}
	}
}