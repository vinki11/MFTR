using System;
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
		}

		public Enfant(Entities.Enfants enfants) : this(enfants.Dossier_ID)
		{
			CurrentChild = enfants;
			AssignChild(CurrentChild);
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
	}
}