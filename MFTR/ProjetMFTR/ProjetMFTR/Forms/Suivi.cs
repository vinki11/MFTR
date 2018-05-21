using System;
using System.Linq;
using System.Windows.Forms;
using ProjetMFTR.DataAccess;
using ProjetMFTR.Resources;

namespace ProjetMFTR
{
	public partial class Suivi : Form
	{

		Entities.Suivi CurrentSuivi;
		Connexion.ConnexionUpdater<Entities.Suivi> connexionUpdater = new Connexion.ConnexionUpdater<Entities.Suivi>();

		public Suivi()
		{
			InitializeComponent();
			CombosInitialisation();
		}

		public Suivi(Entities.Suivi suivi) : this()
		{
			
			cboFolders.DataSource = Connexion.Instance().Dossier.Where((x) => x.Dossier_ID.Equals(suivi.dossier_id)).ToList();
			cboFolders.Enabled = false;

			cboKids.DataSource = Connexion.Instance().Enfants.Where((x) => x.Enfant_ID.Equals(suivi.enfant_id)).ToList();

			cboEmployes.DataSource = Connexion.Instance().Intervenant.Where((x) => x.intervenant_id.Equals(suivi.intervenant_id)).ToList();

			cboMoment.SelectedValue = suivi.moment;
			rtxtRemarque.Text = suivi.remarque;
			dtpDateSuivi.Value = suivi.dateSuivi;
			CurrentSuivi = suivi;
		}

		/// <summary>
		/// Initialisation des combos box
		/// </summary>
		void CombosInitialisation()
		{
			cboFolders.DataSource = Connexion.Instance().Dossier.ToList();
			cboFolders.DisplayMember = ResourcesString.STR_Dossier_ID;
			cboFolders.ValueMember = ResourcesString.STR_Dossier_ID;
			cboFolders.SelectedValue = -1;

			cboKids.DataSource = Connexion.Instance().Enfants.ToList();
			cboKids.DisplayMember = ResourcesString.STR_Name;
			cboKids.ValueMember = ResourcesString.STR_EnfantId;
			cboKids.SelectedValue = -1;

			cboEmployes.DataSource = Connexion.Instance().Intervenant.Where((x) => x.actif == 1).ToList();
			cboEmployes.DisplayMember = ResourcesString.STR_Nom;
			cboEmployes.ValueMember = ResourcesString.STR_IntervenantId;
		}

		/// <summary>
		/// Sauvegarde et création d'un nouveau suivi
		/// </summary>
		private void btnSaveAndNew_Click(object sender, EventArgs e)
		{
			if (!Save()) { return; }
			Clean();
		}

		/// <summary>
		/// Sauvegarde
		/// </summary>
		private void btnSave_Click(object sender, EventArgs e)
		{
			Save();
		}

		/// <summary>
		/// Sauvegarde le suivi présent
		/// </summary>
		private Boolean Save()
		{
			DialogResult result;
			if (CurrentSuivi != null)
			{
				AssignValues();
				connexionUpdater.Update(CurrentSuivi);
				result = MessageBox.Show(ResourcesString.STR_MessageUpdateConfirmation1 + "du suivi" + ResourcesString.STR_MessageUpdateConfirmation2,
				ResourcesString.STR_TitleUpdateConfirmation,
				MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}

			if (((Entities.Dossier)cboFolders.SelectedItem) == null)
			{
				MessageBox.Show("Vous devez sélectionner un dossier pour pouvoir sauvegarder le suivi",
				"Attention",
				MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}

			if (((Entities.Enfants)cboKids.SelectedItem) == null)
			{
				MessageBox.Show("Vous devez sélectionner un enfant pour pouvoir sauvegarder le suivi",
				"Attention",
				MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}

			if (((Entities.Intervenant)cboEmployes.SelectedItem) == null)
			{
				MessageBox.Show("Vous devez sélectionner un intervenant pour pouvoir sauvegarder le suivi",
				"Attention",
				MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}

			CurrentSuivi = new Entities.Suivi();
			AssignValues();
			connexionUpdater.Add(CurrentSuivi);
		  result = MessageBox.Show("La fiche de déroulement des échanges" + ResourcesString.STR_MessageAddConfirmation,
			ResourcesString.STR_TitleAddConfirmation,
			MessageBoxButtons.OK, MessageBoxIcon.Information);
			return true;	
		}

		/// <summary>
		/// Permet de vider tous les contrôles
		/// </summary>
		private void Clean()
		{
			cboEmployes.SelectedValue = -1;
			cboFolders.SelectedValue = -1;
			cboKids.SelectedValue = -1;
			cboMoment.Text = "";
			dtpDateSuivi.Value = DateTime.Now.Date;
			rtxtRemarque.Text = "";
			CurrentSuivi = null;
			cboFolders.Enabled = true;
		}

		/// <summary>
		/// Assignation des valeurs
		/// </summary>
		private void AssignValues()
		{
			  CurrentSuivi.enfant_id = ((Entities.Enfants)cboKids.SelectedItem).Enfant_ID;
				CurrentSuivi.dossier_id = ((Entities.Dossier)cboFolders.SelectedItem).Dossier_ID;
				CurrentSuivi.dateSuivi = dtpDateSuivi.Value.Date;
				CurrentSuivi.intervenant_id = ((Entities.Intervenant)cboEmployes.SelectedItem).intervenant_id;
				CurrentSuivi.remarque = rtxtRemarque.Text;
				CurrentSuivi.moment = cboMoment.Text;
		}
		/// <summary>
		/// Affecter les enfants selon le dossier sélectionné
		/// </summary>
		private void cboFolders_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(cboFolders.SelectedItem == null) { return; }

			cboKids.DataSource = Connexion.Instance().Enfants.Where((x) => x.Dossier_ID.Equals(((Entities.Dossier)cboFolders.SelectedItem).Dossier_ID)).ToList();
		}
	}
}
