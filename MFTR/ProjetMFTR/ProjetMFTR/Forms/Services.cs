using System;
using System.Windows.Forms;
using ProjetMFTR.DataAccess;
using ProjetMFTR.Resources;

namespace ProjetMFTR.Forms
{
	public partial class Services : Form
	{
		#region Members

		private Entities.Services CurrentServices;
		private String CurrentDossierID;
		private Connexion.ConnexionActions<Entities.Services> connexionActions = new Connexion.ConnexionActions<Entities.Services>();

		#endregion Members

		#region Events
		public event EventHandler<Entities.Services> ServicesAdded;
		#endregion

		protected virtual void OnServicesAdded(EventArgs e)
		{
			ServicesAdded?.Invoke(this, CurrentServices);
		}

		public Services(string dossierID)
		{
			InitializeComponent();
			CurrentDossierID = dossierID;

		}

		public Services(Entities.Services Services) : this(Services.Dossier_ID)
		{
			CurrentServices = Services;
			AssignServices(CurrentServices);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Save();
		}

		private Boolean Save()
		{
			DialogResult result;
			if (CurrentServices != null)
			{
				AssignValues();
				connexionActions.Update(CurrentServices);
				result = MessageBox.Show(ResourcesString.STR_MessageUpdateConfirmation1 + "du service" + ResourcesString.STR_MessageUpdateConfirmation2,
				ResourcesString.STR_TitleUpdateConfirmation,
				MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}

			if (string.IsNullOrWhiteSpace(txtNom.Text))
			{
				MessageBox.Show("Vous devez définir une fréquence pour pouvoir ajouter le service",
				"Attention",
				MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}

			CurrentServices = new Entities.Services();
			AssignValues();
			connexionActions.Add(CurrentServices);
			result = MessageBox.Show("Le service " + CurrentServices.Nom + ResourcesString.STR_MessageAddConfirmation,
											ResourcesString.STR_TitleAddConfirmation,
											MessageBoxButtons.OK, MessageBoxIcon.Information);

			OnServicesAdded(new EventArgs());
			return true;
		}

		private void AssignValues()
		{
			CurrentServices.Dossier_ID = CurrentDossierID;
			CurrentServices.Nom = this.txtNom.Text;
			CurrentServices.Duree = this.txtDuree.Text;
			CurrentServices.Journee = this.cboJournée.Text;
			CurrentServices.Frequence = this.cboFrequence.Text;
		}

		private void AssignServices(Entities.Services Services)
		{
			txtNom.Text = Services.Nom;
			txtDuree.Text = Services.Duree;
			cboJournée.Text = Services.Journee;
			cboFrequence.Text = Services.Frequence;
		}
	}
}