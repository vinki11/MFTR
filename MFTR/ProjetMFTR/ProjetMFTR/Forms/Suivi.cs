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
		Connexion.ConnexionActions<Entities.Suivi> connexionActions = new Connexion.ConnexionActions<Entities.Suivi>();
		private bool m_SkipSave = false;
		#endregion


		#region Events
		public event EventHandler SuiviAdded;
		#endregion

		protected virtual void OnSuiviAdded(EventArgs e)
		{
			SuiviAdded?.Invoke(this, e);
		}

		public Suivi()
		{
			InitializeComponent();
			CombosInitialisation();
			bsData.DataSource = Connexion.Instance().Suivi.OrderBy(f => f.dateSuivi).ToList();
			dtpDateSuivi.MaxDate = Helper.CurrentMaxDateTime();
		}

		public Suivi(Entities.Suivi suivi) : this()
		{
			AssignSuivi(suivi);
			bindingNavigator1.Enabled = true;
		}

		void AssignSuivi(Entities.Suivi suivi)
		{
			cboFolders.DataSource = Connexion.Instance().Dossier.Where((x) => x.Dossier_ID.Equals(suivi.dossier_id)).ToList();
			cboFolders.Enabled = false;

			cboKids.DataSource = Connexion.Instance().Enfants.Where((x) => x.Enfant_ID.Equals(suivi.enfant_id)).ToList();

			cboMoment.Text = suivi.moment;
			rtxtRemarque.Text = suivi.remarque;
			dtpDateSuivi.Value = suivi.dateSuivi;
			cboEmployes.Text = Connexion.Instance().Intervenant.FirstOrDefault((x) => x.intervenant_id.Equals(suivi.intervenant_id)).nom;
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

			cboEmployes.DataSource = Connexion.Instance().Intervenant.Where((x) => x.actif == true).ToList();
			cboEmployes.DisplayMember = ResourcesString.STR_Nom;
			cboEmployes.ValueMember = ResourcesString.STR_IntervenantId;
			cboEmployes.SelectedValue = -1;
		}

		/// <summary>
		/// Sauvegarde et création d'un nouveau suivi
		/// </summary>
		private void btnSaveAndNew_Click(object sender, EventArgs e)
		{
			if (!Save(true)) { return; }
			Clean();
			CombosInitialisation();
		}

		/// <summary>
		/// Sauvegarde
		/// </summary>
		private void btnSave_Click(object sender, EventArgs e)
		{
			Save(true);
		}

		/// <summary>
		/// Sauvegarde le suivi présent
		/// </summary>
		private Boolean Save(bool skipValidation)
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

			CurrentEntity = new Entities.Suivi();
			AssignValues();
			connexionActions.Add(CurrentEntity);
			bindingNavigator1.Enabled = true;
			bsData.DataSource = Connexion.Instance().Suivi.OrderBy(f => f.dateSuivi).ToList();
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

		/// <summary>
		/// Assignation des valeurs
		/// </summary>
		private void AssignValues()
		{
			CurrentEntity.enfant_id = ((Entities.Enfants)cboKids.SelectedItem).Enfant_ID;
			CurrentEntity.dossier_id = ((Entities.Dossier)cboFolders.SelectedItem).Dossier_ID;
			CurrentEntity.dateSuivi = dtpDateSuivi.Value.Date;
			CurrentEntity.intervenant_id = ((Entities.Intervenant)cboEmployes.SelectedItem).intervenant_id;
			CurrentEntity.remarque = rtxtRemarque.Text;
			CurrentEntity.moment = cboMoment.Text;
		}
		/// <summary>
		/// Affecter les enfants selon le dossier sélectionné
		/// </summary>
		private void cboFolders_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboFolders.SelectedItem == null) { return; }

			cboKids.DataSource = Connexion.Instance().Enfants.Where((x) => x.Dossier_ID.Equals(((Entities.Dossier)cboFolders.SelectedItem).Dossier_ID)).ToList();
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
			bsData.MoveNext();
			CurrentEntity = (Entities.Suivi)bsData.Current;
			AssignSuivi(CurrentEntity);
		}

		private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
		{
			bsData.MoveLast();
			CurrentEntity = (Entities.Suivi)bsData.Current;
			AssignSuivi(CurrentEntity);
		}

		private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
		{
			bsData.MoveFirst();
			CurrentEntity = (Entities.Suivi)bsData.Current;
			AssignSuivi(CurrentEntity);
		}

		private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
		{
			bsData.MovePrevious();
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
				e.Cancel = !Save(true);
			}

		}
	}
}
