using System;
using System.Linq;
using System.Windows.Forms;
using ProjetMFTR.DataAccess;
using ProjetMFTR.Resources;

namespace ProjetMFTR
{
	public partial class Suivi : Form
	{
		#region Members

		Entities.Suivi CurrentSuivi;
		Connexion.ConnexionActions<Entities.Suivi> connexionActions = new Connexion.ConnexionActions<Entities.Suivi>();

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
			cboEmployes.SelectedValue = -1;
		}

		/// <summary>
		/// Sauvegarde et création d'un nouveau suivi
		/// </summary>
		private void btnSaveAndNew_Click(object sender, EventArgs e)
		{
			if (!Save()) { return; }
			Clean();
			CombosInitialisation();
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
				connexionActions.Update(CurrentSuivi);
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
			connexionActions.Add(CurrentSuivi);
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
			CurrentSuivi = null;
			cboFolders.Enabled = true;
			bindingNavigator1.Enabled = false;
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
			var obj = bsData.List.OfType<Entities.Suivi>().ToList().Find(f => f == CurrentSuivi);
			var index = bsData.IndexOf(obj);
			if (index.Equals((Connexion.Instance().Suivi.AsEnumerable().Count() - 1))) { return; }

			AssignSuivi(Connexion.Instance().Suivi.AsEnumerable().OrderBy(f => f.dateSuivi).ElementAtOrDefault(index + 1));
		}

		private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
		{
			AssignSuivi(Connexion.Instance().Suivi.AsEnumerable().OrderByDescending((x) => x.dateSuivi).FirstOrDefault());
		}

		private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
		{
			AssignSuivi(Connexion.Instance().Suivi.AsEnumerable().OrderBy((x) => x.dateSuivi).FirstOrDefault());
		}

		private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
		{
			var obj = bsData.List.OfType<Entities.Suivi>().ToList().Find(f => f == CurrentSuivi);
			var index = bsData.IndexOf(obj);
			if (index.Equals(bsData.IndexOf(Connexion.Instance().Suivi.AsEnumerable().OrderBy((x) => x.dateSuivi).FirstOrDefault()))) { return; }

			AssignSuivi(Connexion.Instance().Suivi.AsEnumerable().OrderBy(f => f.dateSuivi).ElementAtOrDefault(index - 1));
		}
		#endregion

	}
}
