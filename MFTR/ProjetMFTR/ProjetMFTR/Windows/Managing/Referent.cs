using System;
using System.Linq;
using System.Windows.Forms;
using ProjetMFTR.DataAccess;

namespace ProjetMFTR.Forms
{
	public partial class Referent : Form
	{
		private Entities.Adultes CurrentAdulte;
		private Entities.Referent CurrentEntity;
		private bool m_SkipSave = false;

		public Referent()
		{
			InitializeComponent();
			tabControl.SelectedTab = tbInfo;
		}

		public Referent(Entities.Referent referent) : this()
		{
			CurrentEntity = referent;
			CurrentAdulte = referent.Adultes;
			AssignReferent();
			gvPhone.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
			bsTelephone.DataSource = CurrentAdulte.Telephone.ToList();
		}

		#region Events

		public event EventHandler ReferentAdded;

		#endregion Events

		protected virtual void OnReferentAdded(EventArgs e)
		{
			ReferentAdded?.Invoke(this, e);
		}

		private void AssignReferent()
		{
			txtCourriel.Text = CurrentAdulte.Courriel;
			txtNom.Text = CurrentAdulte.Nom;
			txtPrenom.Text = CurrentAdulte.Prenom;
			txtOrganisation.Text = CurrentEntity.Organisation;
			cboType.Text = CurrentEntity.Type;
			rtxtNotes.Text = CurrentAdulte.Note;
			txtReferentId.Text = CurrentEntity.Referent_ID;
		}

		/// <summary>
		/// Permet de mettre les valeurs de l'adultes
		/// </summary>
		private void AssignValuesAdultes()
		{
			if (CurrentAdulte == null) { return; }

			CurrentAdulte.Nom = txtNom.Text;
			CurrentAdulte.Prenom = txtPrenom.Text;
			CurrentAdulte.Courriel = txtCourriel.Text;
			CurrentAdulte.Note = rtxtNotes.Text;
		}

		/// <summary>
		/// Assignation des valeurs
		/// </summary>
		private void AssignValuesReferent()
		{
			if (CurrentEntity == null) { return; }

			CurrentEntity.Referent_ID = txtReferentId.Text;
			CurrentEntity.Organisation = txtOrganisation.Text;
			CurrentEntity.Type = cboType.Text;
			CurrentEntity.Adultes = CurrentAdulte;
			CurrentEntity.Adulte_ID = CurrentAdulte.Adulte_ID;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Save();
		}

		private void btnSaveAndNew_Click(object sender, EventArgs e)
		{
			if (!Save()) { return; }
			Clean();
		}

		/// <summary>
		/// Permet de vider tous les contrôles
		/// </summary>
		private void Clean()
		{
			txtCourriel.Text = "";
			txtNom.Text = "";
			txtPrenom.Text = "";
			txtOrganisation.Text = "";
			cboType.Text = "";
			rtxtNotes.Text = "";
			CurrentEntity = null;
			CurrentAdulte = null;
			txtReferentId.Text = "";
		}

		/// <summary>
		/// Avant la fermeture de la fenêtre, nous allons sauvegarder
		/// </summary>
		private void Referent_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (m_SkipSave)
			{
				e.Cancel = false;
			}
			else
			{
				e.Cancel = !Save();
				OnReferentAdded(new EventArgs());
			}
		}

		/// <summary>
		/// Sauvegarde le suivi présent
		/// </summary>
		private Boolean Save()
		{
			DialogResult result;
			if (CurrentEntity != null && CurrentAdulte != null)
			{
				var oldId = CurrentEntity.Referent_ID;
				var newId = txtReferentId.Text;

				if (oldId != newId)
				{
					Connexion.connexionActionsReferents.UpdateReferentId(oldId, newId);
					CurrentEntity = Connexion.Instance().Referent.Single(x => x.Referent_ID == newId);
				}

				AssignValuesAdultes();
				AssignValuesReferent();
				Connexion.connexionActionsReferents.Update(CurrentEntity);
				//Connexion.connexionActionsReferents.ObjectContextUpdater();
				Connexion.connexionActionsAdultes.Update(CurrentAdulte);
				//Connexion.connexionActionsAdultes.ObjectContextUpdater();

				return true;
			}

			if (string.IsNullOrWhiteSpace(txtReferentId.Text))
			{
				result = MessageBox.Show("Vous devez entrer un numéro de référent",
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

			CurrentEntity = new Entities.Referent();
			CurrentAdulte = new Entities.Adultes();

			AssignValuesAdultes();
			Connexion.connexionActionsAdultes.Add(CurrentAdulte);
			//Connexion.connexionActionsAdultes.ObjectContextUpdater();
			AssignValuesReferent();
			Connexion.connexionActionsReferents.Add(CurrentEntity);
			//Connexion.connexionActionsReferents.ObjectContextUpdater();
			OnReferentAdded(new EventArgs());
			return true;
		}

		private void gvPhone_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
		{
			e.ContextMenuStrip = PhoneContext;
		}

		private void remove__Click(object sender, EventArgs e)
		{
			DataGridViewRow row = gvPhone.CurrentRow;
			if (!Connexion.Instance().Telephone.Any(x => x.Tel_ID == ((Entities.Telephone)row.DataBoundItem).Tel_ID)) { return; }

			Connexion.Instance().Telephone.Remove((Entities.Telephone)row.DataBoundItem);
			Connexion.Instance().SaveChanges();

			bsTelephone.DataSource = CurrentAdulte.Telephone.ToList();
		}

		private void gvPhone_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			if (CurrentAdulte == null) { return; }
			var telephone = (Entities.Telephone)bsTelephone.Current;

			if (telephone == null) { return; }
			if (telephone.Adulte_ID != null) { return; }

			telephone.Adulte_ID = CurrentAdulte.Adulte_ID;
			telephone.Adultes = CurrentAdulte;
			Connexion.connexionActionsTelephone.Add(telephone);
			//Connexion.connexionActionsTelephone.ObjectContextUpdater();
		}
	}
}