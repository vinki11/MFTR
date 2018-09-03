using ProjetMFTR.DataAccess;
using ProjetMFTR.DbConnexion.Helper;
using ProjetMFTR.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetMFTR.Forms
{
	public partial class Parent : Form
	{
		#region Members

		Entities.Parent CurrentParent;
		Entities.Adultes CurrentAdulte;
		String CurrentDossierID;
		Connexion.ConnexionActions<Entities.Adultes> connexionActionsAdulte = new Connexion.ConnexionActions<Entities.Adultes>();
		Connexion.ConnexionActions<Entities.Parent> connexionActionsParent = new Connexion.ConnexionActions<Entities.Parent>();

		#endregion

		#region Events
		public event EventHandler<Entities.Parent> ParentAdded;
		#endregion

		protected virtual void OnParentAdded(EventArgs e)
		{
			ParentAdded?.Invoke(this, CurrentParent);
		}

		public Parent(string dossierId)
		{
			InitializeComponent();
			CurrentDossierID = dossierId;
			dtpNaissance.MaxDate = Helper.CurrentMaxDateTime();
		}

		public Parent(Entities.Parent parent) : this(parent.Adultes.Dossier_ID)
		{
			CurrentParent = parent;
			CurrentAdulte = parent.Adultes;
			AssignParent();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Save();
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

		private void AssignParent()
		{
			txtNom.Text = CurrentAdulte.Nom;
			txtPrenom.Text = CurrentAdulte.Prenom;

			dtpNaissance.Value = CurrentParent.Naissance.HasValue ? CurrentParent.Naissance.Value : DateTime.Now;
			cboStatut.Text = CurrentParent.Statut;
			cboSexe.Text = CurrentParent.Sexe;
		}

		private Boolean Save()
		{
			DialogResult result;
			if (CurrentParent != null && CurrentAdulte != null)
			{
				AssignValuesAdultes();
				AssignValuesParent();
				connexionActionsParent.Update(CurrentParent);
				connexionActionsAdulte.Update(CurrentAdulte);
				result = MessageBox.Show(ResourcesString.STR_MessageUpdateConfirmation1 + "du parent" + ResourcesString.STR_MessageUpdateConfirmation2,
				ResourcesString.STR_TitleUpdateConfirmation,
				MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}

			//Si nouveau Parent
			CurrentAdulte = new Entities.Adultes();
			CurrentParent = new Entities.Parent();

			AssignValuesAdultes();
			connexionActionsAdulte.Add(CurrentAdulte);
			AssignValuesParent();

			connexionActionsParent.Add(CurrentParent);
			result = MessageBox.Show("Le parent " + CurrentAdulte.Prenom + " " + CurrentAdulte.Nom + ResourcesString.STR_MessageAddConfirmation,
											ResourcesString.STR_TitleAddConfirmation,
											MessageBoxButtons.OK, MessageBoxIcon.Information);

			OnParentAdded(new EventArgs());
			return true;
		}
	}
}
