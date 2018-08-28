using System;
using System.Linq;
using System.Windows.Forms;
using ProjetMFTR.DataAccess;
using ProjetMFTR.Resources;

namespace ProjetMFTR.Forms
{
	public partial class Communication : Form
	{
		Entities.Communication CurrentEntity;
		Connexion.ConnexionActions<Entities.Communication> connexionActions = new Connexion.ConnexionActions<Entities.Communication>();
		public event EventHandler<Entities.Communication> CommunicationAdded;

		public Communication()
		{
			InitializeComponent();
			Init();
			bsData.DataSource = Connexion.Instance().Communication.OrderBy(f => f.DateComm).ToList();
		}

		public Communication(Entities.Communication communication) : this()
		{
			CurrentEntity = communication;
			AssignCommunication(CurrentEntity);
		}

		public void Init()
		{
			InitialiseCombos();
		}

		protected virtual void OnCommunicationAdded(EventArgs e)
		{
			CommunicationAdded?.Invoke(this, CurrentEntity);

		}
		/// <summary>W
		/// Initialisation du combobox des enfants
		/// </summary>
		private void InitialiseCombos()
		{
			cboFolders.DataSource = Connexion.Instance().Dossier.ToList();
			cboFolders.DisplayMember = ResourcesString.STR_Dossier_ID;
			cboFolders.ValueMember = ResourcesString.STR_Dossier_ID;
			cboFolders.SelectedValue = -1;

			cboEmployes.DataSource = Connexion.Instance().Intervenant.Where((x) => x.actif == true).ToList();
			cboEmployes.DisplayMember = ResourcesString.STR_Nom;
			cboEmployes.ValueMember = ResourcesString.STR_IntervenantId;
			cboEmployes.SelectedValue = -1;

			cboReferent.DisplayMember = ResourcesString.STR_Adultes + "." + ResourcesString.STR_Nom;
			cboReferent.ValueMember = ResourcesString.STR_ReferentId;

		}

		void AssignCommunication(Entities.Communication communication)
		{
			cboFolders.DataSource = Connexion.Instance().Dossier.Where((x) => x.Dossier_ID.Equals(communication.Dossier_ID)).ToList();
			cboFolders.Enabled = false;

			cboReferent.DataSource = Connexion.Instance().Referent.Where((x) => x.Referent_ID.Equals(communication.Referent_ID)).ToList();

			cboInterlocuteur.Text = communication.Interlocuteur;
			cboMotif.Text = communication.Motif;
			cboTypeCommunication.Text = communication.Type;
			cboEmployes.Text = Connexion.Instance().Intervenant.FirstOrDefault((x) => x.intervenant_id == communication.IdIntervenant)?.nom;
			CurrentEntity = communication;
			if (communication.DateEven.HasValue) { dtpDateEvent.Value = communication.DateEven.Value; }
			if (communication.DateComm.HasValue) { dtpDateSuivi.Value = communication.DateComm.Value; }
			dtpHours.Value = Convert.ToDateTime(communication.Heure.Value.ToString());
			rtxtNotes.Text = communication.Note;
		}

		/// <summary>
		/// Assignation des valeurs
		/// </summary>
		private void AssignValues()
		{
			if (CurrentEntity == null) { return; }

			CurrentEntity.Dossier_ID = ((Entities.Dossier)cboFolders.SelectedItem).Dossier_ID;
			CurrentEntity.DateComm = dtpDateSuivi.Value.Date;
			CurrentEntity.DateEven = dtpDateEvent.Value.Date;
			CurrentEntity.Heure = new TimeSpan(dtpHours.Value.Hour, dtpHours.Value.Minute, dtpHours.Value.Second);
			CurrentEntity.Referent_ID = (cboReferent.SelectedItem != null) ? ((Entities.Referent)cboReferent.SelectedItem).Referent_ID : null;
			CurrentEntity.Note = rtxtNotes.Text;
			CurrentEntity.Interlocuteur = cboInterlocuteur.Text;
			CurrentEntity.Type = cboTypeCommunication.Text;
			CurrentEntity.Motif = cboMotif.Text;
			CurrentEntity.Intervenant = cboEmployes.Text;
			CurrentEntity.IdIntervenant = ((Entities.Intervenant)cboEmployes.SelectedItem).intervenant_id;
		}

		/// <summary>
		/// Affecter les enfants selon le dossier sélectionné
		/// </summary>
		private void cboFolders_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboFolders.SelectedItem == null) { return; }

			cboReferent.DataSource = Connexion.Instance().Referent.Where(x => x.Referent_ID == ((Entities.Dossier)cboFolders.SelectedItem).Referent_ID).ToList();
		}

		#region Binding

		private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
		{
			bsData.MoveNext();
			CurrentEntity = (Entities.Communication)bsData.Current;
			AssignCommunication(CurrentEntity);
		}

		private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
		{
			bsData.MoveLast();
			CurrentEntity = (Entities.Communication)bsData.Current;
			AssignCommunication(CurrentEntity);
		}

		private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
		{
			bsData.MoveFirst();
			CurrentEntity = (Entities.Communication)bsData.Current;
			AssignCommunication(CurrentEntity);
		}

		private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
		{
			bsData.MovePrevious();
			CurrentEntity = (Entities.Communication)bsData.Current;
			AssignCommunication(CurrentEntity);
		}
		#endregion

		private void btnSaveAndNew_Click(object sender, EventArgs e)
		{
			if (!Save()) { return; }
			Clean();
			InitialiseCombos();
		}

		/// <summary>
		/// Sauvegarde le suivi présent
		/// </summary>
		private Boolean Save()
		{
			DialogResult result;
			if (CurrentEntity != null)
			{
				AssignValues();
				connexionActions.Update(CurrentEntity);
				result = MessageBox.Show(ResourcesString.STR_MessageUpdateConfirmation1 + "de la communication" + ResourcesString.STR_MessageUpdateConfirmation2,
				ResourcesString.STR_TitleUpdateConfirmation,
				MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}

			if (((Entities.Dossier)cboFolders.SelectedItem) == null)
			{
				MessageBox.Show("Vous devez sélectionner un dossier pour pouvoir sauvegarder la communication",
				"Attention",
				MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}

			CurrentEntity = new Entities.Communication();
			AssignValues();
			connexionActions.Add(CurrentEntity);
			bindingNavigator1.Enabled = true;
			bsData.DataSource = Connexion.Instance().Communication.OrderBy(f => f.DateComm).ToList();
			OnCommunicationAdded(new EventArgs());
			return true;
		}

		/// <summary>
		/// Permet de vider tous les contrôles
		/// </summary>
		private void Clean()
		{
			cboEmployes.SelectedValue = -1;
			cboFolders.SelectedValue = -1;
			cboReferent.Text = "";
			cboMotif.Text = "";
			cboInterlocuteur.Text = "";
			dtpDateSuivi.Value = DateTime.Now.Date;
			dtpDateEvent.Value = DateTime.Now.Date;
			dtpHours.Value = DateTime.Now.Date;
			rtxtNotes.Text = "";
			CurrentEntity = null;
			cboFolders.Enabled = true;
			bindingNavigator1.Enabled = false;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Save();
		}

	}
}
