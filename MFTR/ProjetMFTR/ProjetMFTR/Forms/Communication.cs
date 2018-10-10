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
		private Entities.Communication CurrentEntity;
		private bool initialize = false;
		private Connexion.ConnexionActions<Entities.Communication> connexionActions = new Connexion.ConnexionActions<Entities.Communication>();

		public event EventHandler<Entities.Communication> CommunicationAdded;

		private bool m_SkipSave = false;

		public Communication()
		{
			InitializeComponent();
			Init();
			var list = Connexion.Instance().Communication.OrderBy(x => x.Communication_ID).ThenBy(o => o.Heure);
			bsData.DataSource = list.ToList();
			bindingNavigator1.BindingSource = bsData;
			bindingNavigator1.BindingSource.DataSource = list.ToList();
			bindingNavigator1.BindingSource.Sort = "Communication_ID DESC";
			count.Text = bsData.List.Count.ToString();
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

			cboReferent.DataSource = new List<Entities.Referent>();
			cboReferent.DisplayMember = ResourcesString.STR_Adultes + "." + ResourcesString.STR_Nom;
			cboReferent.ValueMember = ResourcesString.STR_ReferentId;

			cboInterlocuteur.DataSource = new List<Entities.Adultes>();
			cboInterlocuteur.DisplayMember = ResourcesString.STR_FullName;
			cboInterlocuteur.ValueMember = ResourcesString.STR_Adultes_ID;

			initialize = true;
		}

		private void AssignCommunication(Entities.Communication communication)
		{
			cboFolders.DataSource = Connexion.Instance().Dossier.Where((x) => x.Dossier_ID.Equals(communication.Dossier_ID)).ToList();

			var referents = SelectReferents();

			cboReferent.DataSource = referents.ToList();
			cboReferent.Text = referents.FirstOrDefault((x) => x.Referent_ID == (communication.Referent_ID))?.Referent_ID;
			cboInterlocuteur.Text = communication.Interlocuteur;
			cboMotif.Text = communication.Motif;
			cboTypeCommunication.Text = communication.Type;

			var intervenant = Connexion.Instance().Intervenant.FirstOrDefault((x) => x.intervenant_id == communication.IdIntervenant);
			if (intervenant == null)
			{
				cboEmployes.Text = communication.Intervenant;
			}
			else
			{
				cboEmployes.Text = intervenant.nom;
			}
			CurrentEntity = communication;
			rtxtNotes.Text = communication.Note;

			if (communication.DateEven.HasValue)
			{
				dtpDateEvent.CustomFormat = "dd/MM/yyyy";
				dtpDateEvent.Value = communication.DateEven.Value;
			}
			else
			{
				dtpDateEvent.Value = Helper.MinDateTime();
				dtpDateEvent.CustomFormat = " ";
			}

			if (communication.DateComm.HasValue)
			{
				dtpDateCommunication.CustomFormat = "dd/MM/yyyy";
				dtpDateCommunication.Value = communication.DateComm.Value;
			}
			else
			{
				dtpDateCommunication.Value = Helper.MinDateTime();
				dtpDateCommunication.CustomFormat = " ";
			}

			if (communication.Heure.HasValue)
			{
				dtpHours.CustomFormat = "HH:mm:ss";
				dtpHours.Value = Convert.ToDateTime(communication.Heure.Value.ToString());
			}
			else
			{
				dtpHours.Value = Helper.CurrentDateTime();
				dtpHours.CustomFormat = " ";
			}
		}

		/// <summary>
		/// Assignation des valeurs
		/// </summary>
		private void AssignValues()
		{
			if (CurrentEntity == null) { return; }

			CurrentEntity.Dossier_ID = ((Entities.Dossier)cboFolders.SelectedItem).Dossier_ID;
			DateTime date = new DateTime();

			DateTime.TryParse(dtpDateCommunication.Text, out date);
			CurrentEntity.DateComm = date == DateTime.MinValue ? (DateTime?)null : date;

			DateTime.TryParse(dtpDateEvent.Text, out date);
			CurrentEntity.DateEven = date == DateTime.MinValue ? (DateTime?)null : date;

			DateTime.TryParse(dtpHours.Text, out date);
			CurrentEntity.Heure = date == DateTime.MinValue ? (TimeSpan?)null : new TimeSpan(date.Hour, date.Minute, date.Second);

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

			if (cboFolders.SelectedItem == null) { return; }

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
			if (referent.Adultes == null) { return; }

			cboInterlocuteur.Text = referent.Adultes.Nom + ", " + referent.Adultes.Prenom;
		}

		#region Binding

		private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
		{
			CurrentEntity = (Entities.Communication)bsData.Current;
			AssignCommunication(CurrentEntity);
		}

		private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
		{
			CurrentEntity = (Entities.Communication)bsData.Current;
			AssignCommunication(CurrentEntity);
		}

		private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
		{
			CurrentEntity = (Entities.Communication)bsData.Current;
			AssignCommunication(CurrentEntity);
		}

		private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
		{
			CurrentEntity = (Entities.Communication)bsData.Current;
			AssignCommunication(CurrentEntity);
		}

		#endregion Binding

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

				return true;
			}

			if (((Entities.Dossier)cboFolders.SelectedItem) == null)
			{
				result = MessageBox.Show("Vous devez sélectionner un dossier pour pouvoir sauvegarder la communication",
				"Attention",
				MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);

				if (result == DialogResult.Cancel)
				{
					m_SkipSave = true;
					Close();
				}
				m_SkipSave = false;
				return false;
			}

			CurrentEntity = new Entities.Communication();
			AssignValues();
			connexionActions.Add(CurrentEntity);
			bindingNavigator1.Enabled = true;
			bsData.DataSource = Connexion.Instance().Communication.OrderByDescending(f => f.Communication_ID).ToList();
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
			cboTypeCommunication.Text = "";
			dtpDateCommunication.Value = DateTime.Now.Date;
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
			if (m_SkipSave)
			{
				e.Cancel = false;
			}
			else
			{
				e.Cancel = !Save();
			}
		}

		private void dtpDateEvent_ValueChanged(object sender, EventArgs e)
		{
			dtpDateEvent.CustomFormat = "yyyy/MM/dd";
		}

		private void dtpHours_ValueChanged(object sender, EventArgs e)
		{
			dtpHours.CustomFormat = "HH:mm:ss";
		}

		private void dtpDateEvent_KeyDown(object sender, KeyEventArgs e)
		{
			if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
			{
				dtpDateEvent.Value = Helper.MinDateTime();
				dtpDateEvent.CustomFormat = " ";
			}
		}

		private void dtpDateCommunication_KeyDown(object sender, KeyEventArgs e)
		{
			if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
			{
				dtpDateCommunication.Value = Helper.MinDateTime();
				dtpDateCommunication.CustomFormat = " ";
			}
		}

		private void dtpHours_KeyDown(object sender, KeyEventArgs e)
		{
			if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
			{
				dtpHours.Value = Helper.CurrentDateTime();
				dtpHours.CustomFormat = " ";
			}
		}

		private void dtpDateCommunication_ValueChanged(object sender, EventArgs e)
		{
			dtpDateCommunication.CustomFormat = "yyyy/MM/dd";
		}
	}
}