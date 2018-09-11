using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ProjetMFTR.DataAccess;
using ProjetMFTR.DbConnexion.Helper;
using ProjetMFTR.Resources;

namespace ProjetMFTR.Forms
{
	public partial class Communication : Form
	{
		Entities.Communication CurrentEntity;
		bool initialize = false;
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
			dtpDateEvent.MaxDate = Helper.CurrentMaxDateTime();
			dtpDateSuivi.MaxDate = Helper.CurrentMaxDateTime();
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

			cboReferent.DataSource = new List<Entities.Referent>();
			cboReferent.DisplayMember = ResourcesString.STR_Adultes + "." + ResourcesString.STR_Nom;
			cboReferent.ValueMember = ResourcesString.STR_ReferentId;


			cboInterlocuteur.DisplayMember = ResourcesString.STR_Prenom;
			cboInterlocuteur.ValueMember = ResourcesString.STR_Adultes_ID;

			initialize = true;
		}

		void AssignCommunication(Entities.Communication communication)
		{
			cboFolders.DataSource = Connexion.Instance().Dossier.Where((x) => x.Dossier_ID.Equals(communication.Dossier_ID)).ToList();
			cboFolders.Enabled = false;

			var parents = Connexion.Instance().Dossier.SelectMany(x => x.Adultes).Where(o => o.Dossier_ID == communication.Dossier_ID).ToList();

			//cboInterlocuteur.Items.AddRange(parents.SelectMany(x => x.Nom + ", " + x.Prenom).Cast<object>().ToList().ToArray());

			var referents = SelectReferents();

			cboReferent.DataSource = referents.ToList();
			cboReferent.Text = referents.FirstOrDefault((x) => x.Referent_ID == (communication.Referent_ID))?.Referent_ID;
			cboInterlocuteur.Text = communication.Interlocuteur;
			cboMotif.Text = communication.Motif;
			cboTypeCommunication.Text = communication.Type;
			cboEmployes.Text = Connexion.Instance().Intervenant.FirstOrDefault((x) => x.intervenant_id == communication.IdIntervenant)?.nom;
			CurrentEntity = communication;
			if (communication.DateEven.HasValue) { dtpDateEvent.Value = communication.DateEven.Value; }
			if (communication.DateComm.HasValue) { dtpDateSuivi.Value = communication.DateComm.Value; }
			if (communication.Heure.HasValue) { dtpHours.Value = Convert.ToDateTime(communication.Heure.Value.ToString()); }
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
			CurrentEntity.Referent_ID = ((Entities.Referent)cboReferent.SelectedItem)?.Referent_ID;
			CurrentEntity.Note = rtxtNotes.Text;
			CurrentEntity.Interlocuteur = cboInterlocuteur.Text;
			CurrentEntity.Type = cboTypeCommunication.Text;
			CurrentEntity.Motif = cboMotif.Text;
			CurrentEntity.Intervenant = cboEmployes.Text;
			CurrentEntity.IdIntervenant = ((Entities.Intervenant)cboEmployes.SelectedItem)?.intervenant_id;
		}

		/// <summary>
		/// Affecter les enfants selon le dossier sélectionné
		/// </summary>
		private void cboFolders_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!initialize) { return; }

			//if (string.IsNullOrWhiteSpace(cboFolders.Text)) { return; }

			//cboReferent.DataSource = Connexion.Instance().Referent.Where(x => x.Referent_ID == ((Entities.Dossier)cboFolders.SelectedItem).Referent_ID).ToList();
			cboInterlocuteur.DataSource = ((Entities.Dossier)cboFolders.SelectedItem).Adultes.ToList();
			var referents = SelectReferents();

			if (!referents.Any()) { return; }
			cboReferent.DataSource = referents.ToList();
		}

		private List<Entities.Referent> SelectReferents()
		{
			if (!initialize) { return new List<Entities.Referent>(); }
			if (((Entities.Dossier)cboFolders.SelectedItem) == null) { return new List<Entities.Referent>(); }

			var lienReferrents = ((Entities.Dossier)cboFolders.SelectedItem).Adultes.SelectMany(x => x.Parent.SelectMany(o => o.LienReferrent)).ToList();
			var referents = Connexion.Instance().Referent.ToList().Where(x => lienReferrents.Any(p => p.Referent_ID == x.Referent_ID)).ToList();
			var kids = ((Entities.Dossier)cboFolders.SelectedItem).Enfants.Select(o => o.Referent_ID).ToList();
			var kidReferent = Connexion.Instance().Referent.Where(x => kids.Any(o => o == x.Referent_ID)).ToList();
			referents.Concat(kidReferent);
			return referents.ToList();
		}
		/// <summary>
		/// Survient au changement d'un référent
		/// </summary>
		private void cboReferent_SelectedIndexChanged(object sender, EventArgs e)
		{
			var referent = ((Entities.Referent)cboReferent.SelectedItem);
			if (referent == null) { return; }

			cboInterlocuteur.Text = referent.Adultes.Nom + ", " + referent.Adultes.Prenom;
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
				//result = MessageBox.Show(ResourcesString.STR_MessageUpdateConfirmation1 + "de la communication" + ResourcesString.STR_MessageUpdateConfirmation2,
				//ResourcesString.STR_TitleUpdateConfirmation,
				//MessageBoxButtons.OK, MessageBoxIcon.Information);
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
			initialize = false;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Save();
		}

		/// <summary>
		/// Avant la fermeture de la fenêtre, nous allons sauvegarder
		/// </summary>
		private void Communication_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = !Save();
		}


	}
}
