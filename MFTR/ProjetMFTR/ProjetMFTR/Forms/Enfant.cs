using System;
using System.Windows.Forms;
using ProjetMFTR.DataAccess;
using ProjetMFTR.Resources;

namespace ProjetMFTR.Forms
{
	public partial class Enfant : Form
	{
		#region Members

		private Entities.Enfants CurrentChild;
		private String CurrentDossierID;
		private Connexion.ConnexionActions<Entities.Enfants> connexionActions = new Connexion.ConnexionActions<Entities.Enfants>();

		#endregion Members

		#region Events
		public event EventHandler<Entities.Enfants> ChildAdded;
		#endregion

		protected virtual void OnChildAdded(EventArgs e)
		{
			ChildAdded?.Invoke(this, CurrentChild);
		}

		public Enfant(string dossierID)
		{
			InitializeComponent();
			CurrentDossierID = dossierID;
		}

		public Enfant(Entities.Enfants enfants) : this(enfants.Dossier_ID)
		{
			CurrentChild = enfants;
			AssignChild(CurrentChild);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Save();
		}

		private Boolean Save()
		{
			DialogResult result;
			if (CurrentChild != null)
			{
				AssignValues();
				connexionActions.Update(CurrentChild);
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

			CurrentChild = new Entities.Enfants();
			AssignValues();
			connexionActions.Add(CurrentChild);
			result = MessageBox.Show("L'enfant " + CurrentChild.Prenom + " " + CurrentChild.Nom + ResourcesString.STR_MessageAddConfirmation,
											ResourcesString.STR_TitleAddConfirmation,
											MessageBoxButtons.OK, MessageBoxIcon.Information);

			OnChildAdded(new EventArgs());
			return true;
		}

		private void AssignValues()
		{
			CurrentChild.Dossier_ID = CurrentDossierID;
			CurrentChild.Naissance = this.dtpNaissance.Value.Date;
			CurrentChild.Nom = this.txtNom.Text;
			CurrentChild.Prenom = this.txtPrenom.Text;
			CurrentChild.Accueil = this.cboStatut.SelectedIndex == 1 ? false : true;
			CurrentChild.Sexe = this.cboSexe.SelectedItem.ToString();
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