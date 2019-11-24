using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ProjetMFTR.DataAccess;
using ProjetMFTR.DbConnexion.Helper;
using ProjetMFTR.Entities.Helper;
using ProjetMFTR.Resources;

namespace ProjetMFTR.Forms
{
	public partial class DossierNouveau : Form
	{
		#region Members

		private Entities.Dossier CurrentDossier;


		private Parent m_NewParent;
		private Enfant m_NewEnfant;
		private Services m_NewServices;

		#endregion Members

		#region Events

		public event EventHandler<Entities.Dossier> FolderUpdated;

		#endregion Events

		public DossierNouveau()
		{
			InitializeComponent();
			Init();
			Nouveau();
		}

		public DossierNouveau(Entities.Dossier dossier) : this()
		{
			AssignFolder(dossier);
			this.Text = "Modification d'un dossier";
			SetButtonVisibility();
		}

		private void OnFolderUpdated(EventArgs e)
		{
			FolderUpdated?.Invoke(this, CurrentDossier);
		}

		private void btnSaveAndQuit_Click(object sender, EventArgs e)
		{
			Save();
		}

		private void Init()
		{
			listParents.Columns["Nom"].DataPropertyName = "Adultes.Nom";
			listParents.Columns["SubName"].DataPropertyName = "Adultes.Prenom";

			SetButtonVisibility();
			dtpDateOuverture.MaxDate = Helper.CurrentMaxDateTime();
		}

		/// <summary>
		/// Sauvegarde le dossier
		/// </summary>
		private Boolean Save()
		{
			//Valider si un dossier existe déja avec ce numéro si on est en mode ajout
			DialogResult result;
			if (CurrentDossier != null)
			{
				var oldId = CurrentDossier.Dossier_ID;
				var newId = txtNoDossier.Text;
				Connexion.connexionActions.UpdateFolderIDs(oldId, newId);

				if (!Equals(oldId, newId))
				{
					Cursor.Current = Cursors.WaitCursor;
					Connexion.connexionActions.ObjectContextUpdater();
					Connexion.connexionActionsAdultes.ObjectContextUpdater();
					Connexion.connexionActionsEnfants.ObjectContextUpdater();
					Connexion.connexionActionsParent.ObjectContextUpdater();
					Connexion.connexionActionsCommunication.ObjectContextUpdater();
					Cursor.Current = Cursors.Default;
				}
				CurrentDossier = Connexion.Instance().Dossier.FirstOrDefault(x => x.Dossier_ID == newId);
				AssignValues();

				var sucess = Connexion.connexionActions.Update(CurrentDossier);

				if (!sucess) { return false; }

				result = MessageBox.Show(ResourcesString.STR_MessageUpdateConfirmation1 + "du dossier" + ResourcesString.STR_MessageUpdateConfirmation2,
				ResourcesString.STR_TitleUpdateConfirmation,
				MessageBoxButtons.OK, MessageBoxIcon.Information);
				OnFolderUpdated(new EventArgs());
				return true;
			}

			if (string.IsNullOrWhiteSpace(txtNoDossier.Text))
			{
				MessageBox.Show("Vous devez définir un numéro de dossier pour pouvoir ajouter le dossier",
				"Attention",
				MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}

			if (Connexion.Instance().Dossier.Any(x => x.Dossier_ID == txtNoDossier.Text))
			{
				MessageBox.Show("Le numéro de dossier doit être unique",
				"Erreur",
				MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}

			CurrentDossier = new Entities.Dossier();
			CurrentDossier.Dossier_ID = txtNoDossier.Text;
			AssignValues();

			Connexion.connexionActions.Add(CurrentDossier);
			result = MessageBox.Show("Le dossier " + CurrentDossier.Dossier_ID + ResourcesString.STR_MessageAddConfirmation,
							ResourcesString.STR_TitleAddConfirmation,
							MessageBoxButtons.OK, MessageBoxIcon.Information);

			return true;
		}

		private void AssignFolder(Entities.Dossier dossier)
		{
			txtNoDossier.Text = dossier.Dossier_ID;
			cboType.Text = dossier.Type;
			dtpDateOuverture.Value = dossier.Ouverture.HasValue ? dossier.Ouverture.Value : DateTime.MinValue;

			rtxtRemarque.Text = dossier.Remarque;
			CurrentDossier = dossier;

			AssignDataSources();
		}

		private void AssignDataSources()
		{
			if (CurrentDossier == null) { return; }

			var kids = Connexion.Instance().Enfants.Where(x => x.Dossier_ID == CurrentDossier.Dossier_ID).OrderBy(o => o.Naissance).ToList();
			//Connexion.connexionActionsEnfants.ObjectContextUpdater();
			bsDataKids.DataSource = kids;

			var adults = Connexion.Instance().Adultes.Where(x => x.Dossier_ID.Equals(CurrentDossier.Dossier_ID)).ToList();
			//Connexion.connexionActionsAdultes.ObjectContextUpdater();

			var parents = adults.SelectMany(x => x.Parent).ToList();
			//Connexion.connexionActionsParent.ObjectContextUpdater();

			bsDataParents.DataSource = parents;

			var services = Connexion.Instance().Services.Where(x => x.Dossier_ID == CurrentDossier.Dossier_ID).ToList();
			//Connexion.connexionActionsServices.ObjectContextUpdater();

			bsServices.DataSource = services;

			var payments = Connexion.Instance().Payments.Where(x => x.IDFolder == CurrentDossier.Dossier_ID).OrderByDescending(c => c.DatePayment).ToList();

			List<PaymentViewModel> viewModels = new List<PaymentViewModel>();

			foreach (Entities.Payments p in payments)
			{
				PaymentViewModel viewModel = new PaymentViewModel();
				viewModel.Build(p);
				viewModels.Add(viewModel);
			}

			bsPayments.DataSource = viewModels;
		}

		private void AssignValues()
		{
			CurrentDossier.Ouverture = this.dtpDateOuverture.Value.Date;
			CurrentDossier.Remarque = this.rtxtRemarque.Text;
			CurrentDossier.Type = cboType.Text;
			CurrentDossier.Actif = "0";
		}

		private void btnSaveAndNew_Click(object sender, EventArgs e)
		{
			Save();
			Nouveau();
		}

		private void Nouveau()
		{
			this.Text = "Nouveau dossier";
			CurrentDossier = null;

			this.txtNoDossier.Text = "";
			this.dtpDateOuverture.Value = DateTime.Today;
			this.rtxtRemarque.Text = "";
			this.cboType.SelectedIndex = 0;

			bsDataKids.Clear();
			bsDataParents.Clear();
			bsServices.Clear();
		}

		private void btnAddParent_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(txtNoDossier.Text))
			{
				m_NewParent = new Parent(this.txtNoDossier.Text);
				m_NewParent.ParentAdded += new EventHandler<Entities.Parent>(ParentAdded);
				m_NewParent.ShowDialog();
			}
		}

		private void btnAjouterEnfant_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(txtNoDossier.Text))
			{
				m_NewEnfant = new Enfant(txtNoDossier.Text);
				m_NewEnfant.ChildAdded += new EventHandler<Entities.Enfants>(ChildAdded);
				m_NewEnfant.ShowDialog();
			}
		}

		private void ChildAdded(object sender, Entities.Enfants e)
		{
			bsDataKids.Add(e);
		}

		private void ParentAdded(object sender, Entities.Parent e)
		{
			bsDataParents.Add(e);
		}

		private void ServicesAdded(object sender, Entities.Services e)
		{
			bsServices.Add(e);
		}

		/// <summary>
		/// Met à jour le datasource
		/// </summary>
		private void UpdateDataSource(object sender, EventArgs e)
		{
			Init();
			AssignDataSources();
		}

		private void SetButtonVisibility()
		{
			btnAddParent.Enabled = CurrentDossier != null;
			btnAjouterEnfant.Enabled = CurrentDossier != null;
		}

		private void listParents_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			try
			{
				if ((listParents.Rows[e.RowIndex].DataBoundItem != null) &&
								(listParents.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
				{
					e.Value = Helper.BindProperty(
												listParents.Rows[e.RowIndex].DataBoundItem,
												listParents.Columns[e.ColumnIndex].DataPropertyName
											);
				}
			}
			catch (Exception)
			{
				return;
			}
		}

		private void btnAddService_Click(object sender, EventArgs e)
		{
			m_NewServices = new Services(txtNoDossier.Text);
			m_NewServices.ServicesAdded += new EventHandler<Entities.Services>(ServicesAdded);
			m_NewServices.ShowDialog();
		}

		private void btnDelParent_Click(object sender, EventArgs e)
		{
			DataGridViewRow row = listParents.CurrentRow;
			var parent = (Entities.Parent)row.DataBoundItem;

			Connexion.Instance().Parent.Attach(parent);
			Connexion.Instance().Parent.Remove(parent);
			Connexion.Instance().SaveChanges();
			AssignDataSources();
		}

		private void btnDelEnfant_Click(object sender, EventArgs e)
		{
			DataGridViewRow row = listEnfants.CurrentRow;
			var enfants = (Entities.Enfants)row.DataBoundItem;

			Connexion.Instance().Enfants.Attach(enfants);
			Connexion.Instance().Enfants.Remove(enfants);
			Connexion.Instance().SaveChanges();
			AssignDataSources();
		}

		private void btnDelServices_Click(object sender, EventArgs e)
		{
			DataGridViewRow row = gvServices.CurrentRow;
			var services = (Entities.Services)row.DataBoundItem;

			Connexion.Instance().Services.Remove(services);
			Connexion.Instance().SaveChanges();
			AssignDataSources();
		}

		private void listParents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = listParents.CurrentRow;
			m_NewParent = new Parent((Entities.Parent)row.DataBoundItem);
			m_NewParent.FormClosing += new FormClosingEventHandler(UpdateDataSource);
			m_NewParent.ShowDialog();
		}

		private void listEnfants_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = listEnfants.CurrentRow;
			m_NewEnfant = new Enfant((Entities.Enfants)row.DataBoundItem);
			m_NewEnfant.FormClosing += new FormClosingEventHandler(UpdateDataSource);
			m_NewEnfant.ShowDialog();
		}

		private void gvServices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = gvServices.CurrentRow;
			m_NewServices = new Services((Entities.Services)row.DataBoundItem);
			m_NewServices.FormClosing += new FormClosingEventHandler(UpdateDataSource);
			m_NewServices.ShowDialog();
		}
	}
}