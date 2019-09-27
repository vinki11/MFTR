using System;
using System.Linq;
using System.Windows.Forms;
using ProjetMFTR.DataAccess;
using ProjetMFTR.DbConnexion.Helper;
using ProjetMFTR.Resources;

namespace ProjetMFTR
{
	public partial class Suivi : Form
	{
		#region Members

		Entities.Suivi CurrentEntity;
		private bool m_SkipSave = false;
		#endregion


		#region Events
		public event EventHandler SuiviAdded;
		public event EventHandler SuiviUpdated;
		#endregion

		protected virtual void OnSuiviAdded(EventArgs e)
		{
			SuiviAdded?.Invoke(this, e);
		}

		protected virtual void OnSuiviUpdated(EventArgs e)
		{
			SuiviUpdated?.Invoke(this, e);
		}

		public Suivi()
		{
			InitializeComponent();
			CombosInitialisation();
			bsData.DataSource = Connexion.Instance().Suivi.AsNoTracking().OrderBy(f => f.dateSuivi).ToList();
		}

		public Suivi(Entities.Suivi suivi) : this()
		{
			AssignSuivi(suivi);
			bindingNavigator1.Enabled = true;
		}

		void AssignSuivi(Entities.Suivi suivi)
		{
			cboFolders.DataSource = Connexion.Instance().Dossier.AsNoTracking().ToList();
			cboFolders.Text = suivi.dossier_id;
			//cboFolders.Enabled = false;

			cboKids.DataSource = Connexion.Instance().Enfants.AsNoTracking().ToList();
			cboFolders_SelectedIndexChanged(null, null);

			var kid = Connexion.Instance().Enfants.AsNoTracking().FirstOrDefault(x => x.Enfant_ID == suivi.enfant_id);
			cboKids.Text = kid == null ? "" : kid.Name;

			cboMoment.Text = suivi.moment;
			rtxtRemarque.Text = suivi.remarque;
			dtpDateSuivi.Value = suivi.dateSuivi;
			cboEmployes.Text = Connexion.Instance().Intervenant.AsNoTracking().FirstOrDefault((x) => x.intervenant_id.Equals(suivi.intervenant_id)).nom;
			CurrentEntity = suivi;
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

			cboEmployes.DataSource = Connexion.Instance().Intervenant.AsNoTracking().Where((x) => x.actif == true).ToList();
			cboEmployes.DisplayMember = ResourcesString.STR_Nom;
			cboEmployes.ValueMember = ResourcesString.STR_IntervenantId;
			cboEmployes.SelectedValue = -1;
		}

		/// <summary>
		/// Sauvegarde et création d'un nouveau suivi
		/// </summary>
		private void btnSaveAndNew_Click(object sender, EventArgs e)
		{
			var success = ValidateEntity(true);
			if (!success) { return; }
			Save();
			Clean();
			CombosInitialisation();
		}

		/// <summary>
		/// Sauvegarde
		/// </summary>
		private void btnSave_Click(object sender, EventArgs e)
		{
			var success = ValidateEntity(false);
			if (!success) { return; }
			Save();
		}

		/// <summary>
		/// Sauvegarde le suivi présent
		/// </summary>
		private Boolean Save()
		{
			if (CurrentEntity != null)
			{
				CurrentEntity = Connexion.Instance().Suivi.FirstOrDefault(x => x.suivi_id == CurrentEntity.suivi_id);
				AssignValues();
				Connexion.connexionActionsSuivi.Update(CurrentEntity);
				//Connexion.connexionActionsSuivi.ObjectContextUpdater();
				OnSuiviUpdated(new EventArgs());
				return true;
			}


			CurrentEntity = new Entities.Suivi();
			AssignValues();
			Connexion.connexionActionsSuivi.Add(CurrentEntity);
			//Connexion.connexionActionsSuivi.ObjectContextUpdater();
			bindingNavigator1.Enabled = true;
			bsData.DataSource = Connexion.Instance().Suivi.AsNoTracking().OrderBy(f => f.dateSuivi).ToList();
			OnSuiviAdded(new EventArgs());
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
			CurrentEntity = null;
			cboFolders.Enabled = true;
			bindingNavigator1.Enabled = false;
		}

		private bool ValidateEntity(bool skipValidation)
		{
			DialogResult result;
			if (((Entities.Dossier)cboFolders.SelectedItem) == null)
			{
				result = MessageBox.Show("Vous devez sélectionner un dossier pour pouvoir sauvegarder le suivi",
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

			if (((Entities.Enfants)cboKids.SelectedItem) == null && !skipValidation)
			{
				MessageBox.Show("Vous devez sélectionner un enfant pour pouvoir sauvegarder le suivi",
				"Attention",
				MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}

			if (((Entities.Intervenant)cboEmployes.SelectedItem) == null && !skipValidation)
			{
				MessageBox.Show("Vous devez sélectionner un intervenant pour pouvoir sauvegarder le suivi",
				"Attention",
				MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}

			return true;
		}
		/// <summary>
		/// Assignation des valeurs
		/// </summary>
		private void AssignValues()
		{
			var kid = ((Entities.Enfants)cboKids.SelectedItem);
			CurrentEntity.enfant_id = kid == null ? CurrentEntity.enfant_id : kid.Enfant_ID;

			CurrentEntity.dossier_id = ((Entities.Dossier)cboFolders.SelectedItem).Dossier_ID;
			CurrentEntity.dateSuivi = dtpDateSuivi.Value.Date;
			var intervenant = ((Entities.Intervenant)cboEmployes.SelectedItem);

			CurrentEntity.intervenant_id = intervenant == null ? CurrentEntity.intervenant_id : intervenant.intervenant_id;
			CurrentEntity.remarque = rtxtRemarque.Text;
			CurrentEntity.moment = cboMoment.Text;
		}
		/// <summary>
		/// Affecter les enfants selon le dossier sélectionné
		/// </summary>
		private void cboFolders_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboFolders.SelectedItem == null) { return; }

			cboKids.DataSource = Connexion.Instance().Enfants.AsNoTracking().Where((x) => x.Dossier_ID.Equals(((Entities.Dossier)cboFolders.SelectedItem).Dossier_ID)).ToList();
			cboKids.SelectedIndex = -1;
		}

		private void Control_KeyUp(object sender, KeyEventArgs e)
		{
			if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
			{
				this.SelectNextControl((Control)sender, true, true, true, true);
			}
		}

		#region Binding
		private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
		{
			CurrentEntity = (Entities.Suivi)bsData.Current;
			AssignSuivi(CurrentEntity);
		}

		private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
		{
			CurrentEntity = (Entities.Suivi)bsData.Current;
			AssignSuivi(CurrentEntity);
		}

		private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
		{
			CurrentEntity = (Entities.Suivi)bsData.Current;
			AssignSuivi(CurrentEntity);
		}

		private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
		{
			CurrentEntity = (Entities.Suivi)bsData.Current;
			AssignSuivi(CurrentEntity);
		}
		#endregion

		/// <summary>
		/// Avant la fermeture de la fenêtre, nous allons sauvegarder
		/// </summary>
		private void Suivi_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (m_SkipSave)
			{
				e.Cancel = false;
			}
			else
			{
				var success = ValidateEntity(true);
				if (!success) { e.Cancel = true; return; }
				Save();
			}

		}
	}
}
