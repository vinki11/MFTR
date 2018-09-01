using System;
using System.Windows.Forms;
using ProjetMFTR.DataAccess;
using ProjetMFTR.Resources;

namespace ProjetMFTR.Forms
{
	public partial class Enfant : Form
	{
		#region Members

		private Entities.Enfants CurrentEnfant;
		private String CurrentDossierID;
		private Connexion.ConnexionActions<Entities.Enfants> connexionActions = new Connexion.ConnexionActions<Entities.Enfants>();

		#endregion Members

		public Enfant(string dossierID)
		{
			InitializeComponent();
			CurrentDossierID = dossierID;
		}

		public Enfant(Entities.Enfants enfants)
		{
			CurrentEnfant = enfants;
			AssignChild(CurrentEnfant);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Save();
		}

		private Boolean Save()
		{
			DialogResult result;
			if (CurrentEnfant != null)
			{
				AssignValues();
				connexionActions.Update(CurrentEnfant);
				result = MessageBox.Show(ResourcesString.STR_MessageUpdateConfirmation1 + "de l'enfant" + ResourcesString.STR_MessageUpdateConfirmation2,
				ResourcesString.STR_TitleUpdateConfirmation,
				MessageBoxButtons.OK, MessageBoxIcon.Information);
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

			CurrentEnfant = new Entities.Enfants();
			AssignValues();
			connexionActions.Add(CurrentEnfant);
			result = MessageBox.Show("L'enfant " + CurrentEnfant.Prenom + " " + CurrentEnfant.Nom + ResourcesString.STR_MessageAddConfirmation,
											ResourcesString.STR_TitleAddConfirmation,
											MessageBoxButtons.OK, MessageBoxIcon.Information);

			return true;
		}

		private void AssignValues()
		{
			CurrentEnfant.Dossier_ID = CurrentDossierID;
			CurrentEnfant.Naissance = this.dtpNaissance.Value.Date;
			CurrentEnfant.Nom = this.txtNom.Text;
			CurrentEnfant.Prenom = this.txtPrenom.Text;
			CurrentEnfant.Accueil = this.cboStatut.SelectedIndex == 1 ? false : true;
			CurrentEnfant.Sexe = this.cboSexe.SelectedItem.ToString();
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
		}
	}
}