using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;
using ProjetMFTR.DataAccess;
using ProjetMFTR.DbConnexion.Helper;
using ProjetMFTR.Resources;

namespace ProjetMFTR.Forms
{
	public partial class Dossier : Form
	{
		#region Members

		private Communication communication;
		private Entities.Dossier CurrentDossier;
		private DossierNouveau DossierNouveau;
		private DeleteFolder m_DeleteFolder;
		private Enfant m_NewEnfant;
		private Parent m_NewParent;

		#endregion Members

		private DossierNouveau m_NewDossier;

		public Dossier()
		{
			InitializeComponent();
			Init();
		}

		public void Init()
		{
			//Connexion.connexionActions.ObjectContextUpdater();

			var folders = Connexion.Instance().Dossier.OrderByDescending((x) => x.Ouverture).ToList();

			bsData.DataSource = folders;
			gvParents.Columns["Nom"].DataPropertyName = "Adultes.Nom";
			gvParents.Columns["SubName"].DataPropertyName = "Adultes.Prenom";
			gvTelephones.Columns["TelNom"].DataPropertyName = "Adultes.Nom";
			gvTelephones.Columns["TelPrenom"].DataPropertyName = "Adultes.Prenom";

			InitialiseCombos(folders);

			cboFolders.KeyDown += EnterPressed;
			txtFirstName.KeyDown += EnterPressed;
			txtFirstName.KeyDown += EnterPressed;
			txtRechercheTelephone.KeyDown += EnterPressed;
		}

		/// <summary>
		/// Ajout à partir du menu contextuel
		/// </summary>
		private void addRow_Click(object sender, EventArgs e)
		{
			m_NewDossier = new DossierNouveau();
			m_NewDossier.FormClosing += new FormClosingEventHandler(UpdateDataSource);
			m_NewDossier.Show();
		}

		/// <summary>
		/// Assignation des valeurs
		/// </summary>
		private void AssignValues()
		{
			CurrentDossier.Dossier_ID = txtDossier.Text;
			CurrentDossier.Ouverture = dtpDossier.Value.Date;
			CurrentDossier.Type = cboType.Text;
			CurrentDossier.Remarque = rtxtRemarque.Text;
		}

		private void btnAddCommunication_Click(object sender, EventArgs e)
		{
			//Nouvelle communication
			communication = new Communication();
			communication.FormClosing += new FormClosingEventHandler(UpdateDataSource);
			communication.CommunicationAdded += new EventHandler<Entities.Communication>(CommunicationAdded);
			communication.Show();
		}

		private void btnAddFolder_Click(object sender, EventArgs e)
		{
			ReferentList referentList = new ReferentList();
			referentList.Show();
		}

		private void btnClearFilters_Click(object sender, EventArgs e)
		{
			txtFirstName.Text = txtLastName.Text = txtRechercheTelephone.Text = "";
			cboFolders.SelectedValue = -1;
		}

		private void btnRecherche_Click(object sender, EventArgs e)
		{
			string dossier = null;
			List<Entities.Dossier> dossiers = Connexion.Instance().Dossier.ToList();
			List<Entities.Adultes> adultes = Connexion.Instance().Adultes.ToList();

			if (txtFirstName.Text != "")
			{
				var ads = adultes.Where(v => v.Prenom == txtFirstName.Text).ToList();
				dossiers = dossiers.Where(x => ads.Any(o => o.Dossier_ID == x.Dossier_ID)).ToList();
			}

			if (txtLastName.Text != "")
			{
				var ads = adultes.Where(v => v.Nom == txtLastName.Text).ToList();
				dossiers = dossiers.Where(x => ads.Any(o => o.Dossier_ID == x.Dossier_ID)).ToList();
			}

			if (cboFolders.SelectedValue != null)
			{
				dossier = ((Entities.Dossier)cboFolders.SelectedItem).Dossier_ID;
				dossiers = dossiers.Where((x) => x.Dossier_ID.Equals(dossier)).ToList();
			}

			if (txtRechercheTelephone.Text != "")
			{
				adultes = Connexion.Instance().Adultes.ToList();
				var telephones = Connexion.Instance().Telephone.Where(x => x.Telephone1.Equals(txtRechercheTelephone.Text)).ToList();
				var adulte = adultes.Where(x => telephones.Any(v => v.Adulte_ID.Value.Equals(x.Adulte_ID))).ToList();
				dossiers = dossiers.Where(x => adulte.Any(c => c.Dossier_ID.Equals(x.Dossier_ID))).ToList();
			}

			bsData.DataSource = dossiers.OrderByDescending(x => x.Ouverture).ToList();
		}

		private void btnSaveDossier_Click(object sender, EventArgs e)
		{
			AssignValues();
			Connexion.connexionActions.Update(CurrentDossier);
			var result = MessageBox.Show(ResourcesString.STR_MessageUpdateConfirmation1 + "du dossier" + ResourcesString.STR_MessageUpdateConfirmation2,
			ResourcesString.STR_TitleUpdateConfirmation,
			MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void CommunicationAdded(object sender, Entities.Communication e)
		{
			if (((Entities.Dossier)bsData.Current).Dossier_ID.Equals(e.Dossier_ID))
			{
				//Connexion.connexionActionsCommunication.ObjectContextUpdater();

				bsDataCommunication.DataSource = Connexion.Instance().Communication.Where(x => x.Dossier_ID.Equals(e.Dossier_ID)).OrderByDescending(c => c.DateComm).ThenByDescending(o => o.Heure).ToList();
			}
		}

		private void CommunicationUpdated(object sender, EventArgs e)
		{
			//Connexion.connexionActionsCommunication.ObjectContextUpdater();

			bsDataCommunication.DataSource = Connexion.Instance().Communication.Where(x => x.Dossier_ID.Equals(CurrentDossier.Dossier_ID)).OrderByDescending(c => c.DateComm).ThenByDescending(o => o.Heure).ToList();
		}

		private void deleteRow_Click(object sender, EventArgs e)
		{
			DataGridViewRow row = gvParents.CurrentRow;
			if (row == null) return;

			var parent = (Entities.Parent)row.DataBoundItem;

			Connexion.Instance().Parent.Remove(parent);
			Connexion.Instance().SaveChanges();
			OnGvListSelectionChanged();
		}

		/// <summary>
		/// Handler qui survient lorsque nous appuyons sur Enter
		/// </summary>
		private void EnterPressed(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnRecherche.PerformClick();
			}
		}

		/// <summary>
		/// Survient lors du changement d'un dossier
		/// </summary>
		private void FolderEntityUpdated(object sender, Entities.Dossier e)
		{
			var folders = Connexion.Instance().Dossier.AsNoTracking().OrderByDescending((x) => x.Ouverture).ToList();

			InitialiseCombos(folders);

			bsData.DataSource = folders;

			OnGvListSelectionChanged();

			foreach (DataGridViewRow item in gvList.Rows)
			{
				if (item.Cells[0].Value.ToString().Equals(e.Dossier_ID))
				{
					item.Selected = true;
				}
			}
		}

		/// <summary>
		/// Sur le double click sur une row
		/// </summary>
		private void gvCommunications_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = gvCommunications.CurrentRow;
			communication = new Communication((Entities.Communication)row.DataBoundItem);
			communication.CommunicationAdded += new EventHandler<Entities.Communication>(CommunicationAdded);
			communication.CommunicationUpdated += new EventHandler(CommunicationUpdated);
			communication.Show();
		}

		private void gvCommunications_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
		{
			e.ContextMenuStrip = CommunicationContextMenu;
		}

		private void gvKids_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = gvKids.CurrentRow;
			m_NewEnfant = new Enfant((Entities.Enfants)row.DataBoundItem);
			m_NewEnfant.FormClosing += new FormClosingEventHandler(ParentAndChildsUpdated);
			m_NewEnfant.Show();
		}

		/// <summary>
		/// Survient lors du double click sur un dossier
		/// </summary>
		private void gvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = gvList.CurrentRow;
			DossierNouveau = new DossierNouveau((Entities.Dossier)row.DataBoundItem);
			DossierNouveau.FolderUpdated += new EventHandler<Entities.Dossier>(FolderEntityUpdated);
			DossierNouveau.Show();
		}

		private void gvList_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
		{
			e.ContextMenuStrip = DossierContextMenu;
		}

		private void gvList_SelectionChanged(object sender, EventArgs e)
		{
			OnGvListSelectionChanged();
		}

		private void gvParents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = gvParents.CurrentRow;
			m_NewParent = new Parent((Entities.Parent)row.DataBoundItem);
			m_NewParent.FormClosing += new FormClosingEventHandler(ParentAndChildsUpdated);
			m_NewParent.Show();
		}

		private void gvParents_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			try
			{
				if ((gvParents.Rows[e.RowIndex].DataBoundItem != null) &&
								(gvParents.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
				{
					e.Value = Helper.BindProperty(
												gvParents.Rows[e.RowIndex].DataBoundItem,
												gvParents.Columns[e.ColumnIndex].DataPropertyName
											);
				}
			}
			catch (Exception)
			{
				return;
			}
		}

		private void gvParents_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
		{
			//e.ContextMenuStrip = contextMenu;
			//rownum = e.RowIndex;
		}

		private void gvTelephones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			try
			{
				if ((gvTelephones.Rows[e.RowIndex].DataBoundItem != null) &&
								(gvTelephones.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
				{
					e.Value = Helper.BindProperty(
												gvTelephones.Rows[e.RowIndex].DataBoundItem,
												gvTelephones.Columns[e.ColumnIndex].DataPropertyName
											);
				}
			}
			catch (Exception)
			{
				return;
			}
		}

		/// <summary>
		/// Initialisation du combobox des enfants
		/// </summary>
		private void InitialiseCombos(List<Entities.Dossier> folders)
		{
			cboFolders.DataSource = folders;
			cboFolders.DisplayMember = ResourcesString.STR_Dossier_ID;
			cboFolders.ValueMember = ResourcesString.STR_Dossier_ID;
			cboFolders.SelectedValue = -1;
		}

		private void OnGvListSelectionChanged()
		{
			DataGridViewRow row = gvList.CurrentRow;
			if (row == null) return;

			CurrentDossier = (Entities.Dossier)row.DataBoundItem;
			//Connexion.connexionActionsCommunication.ObjectContextUpdater();

			var communications = Connexion.Instance().Communication.Where(x => x.Dossier_ID.Equals(CurrentDossier.Dossier_ID)).ToList();
			bsDataCommunication.DataSource = communications.OrderByDescending(x => x.DateComm).ThenByDescending(o => o.Heure).ToList();

			ParentAndChildsUpdated(null, null);

			//Connexion.connexionActionsAdultes.ObjectContextUpdater();
		}

		private void ParentAndChildsUpdated(object sender, EventArgs e)
		{

			//Connexion.connexionActionsEnfants.ObjectContextUpdater();
			//Connexion.connexionActionsAdultes.ObjectContextUpdater();
			//Connexion.connexionActionsParent.ObjectContextUpdater();

			var kids = Connexion.Instance().Enfants.Where(x => x.Dossier_ID == CurrentDossier.Dossier_ID).OrderBy(o => o.Naissance).ToList();
			bsDataKids.DataSource = kids;

			var adults = Connexion.Instance().Adultes.Where(x => x.Dossier_ID.Equals(CurrentDossier.Dossier_ID)).ToList();

			var parents = adults.SelectMany(x => x.Parent).ToList();

			bsDataParents.DataSource = parents;

			bsTelephones.DataSource = Connexion.Instance().Adultes.Where(x => x.Dossier_ID.Equals(CurrentDossier.Dossier_ID)).ToList().SelectMany(x => x.Telephone).OrderBy(o => o.Adultes.Prenom).ThenBy(p => p.Adultes.Nom).ToList();
		}

		private void Remove_Communication_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Êtes-vous sur de vouloir supprimer cette communication ?",
											"Suppression",
											MessageBoxButtons.YesNo, MessageBoxIcon.Information);

			if (result == DialogResult.No) { return; }

			DataGridViewRow row = gvCommunications.CurrentRow;
			var communication = (Entities.Communication)row.DataBoundItem;
			Connexion.Instance().Communication.Remove(communication);
			Connexion.Instance().SaveChanges();

			OnGvListSelectionChanged();
		}

		private void Remove_Folder_Click(object sender, EventArgs e)
		{
			m_DeleteFolder = new DeleteFolder();
			m_DeleteFolder.FormClosing += new FormClosingEventHandler(UpdateDataSource);
			m_DeleteFolder.Show();
		}

		/// <summary>
		/// Met à jour le datasource
		/// </summary>
		private void UpdateDataSource(object sender, EventArgs e)
		{
			Init();
		}
	}
}