using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetMFTR.DataAccess;
using ProjetMFTR.DbConnexion.Helper;
using ProjetMFTR.Entities;
using ProjetMFTR.Resources;

namespace ProjetMFTR.Forms
{
	public partial class Dossier : Form
	{

		#region Members
		Entities.Dossier CurrentDossier;
		Connexion.ConnexionActions<Entities.Dossier> connexionActions = new Connexion.ConnexionActions<Entities.Dossier>();
		Communication communication;
		DossierNouveau DossierNouveau;

		int rownum = 0;
		#endregion

		private DossierNouveau m_NewDossier;


		public Dossier()
		{
			InitializeComponent();
			Init();
		}

		public void Init()
		{
			bsData.DataSource = Connexion.Instance().Dossier.OrderByDescending((x) => x.Ouverture).ToList();
			gvParents.Columns["Nom"].DataPropertyName = "Adultes.Nom";
			gvParents.Columns["SubName"].DataPropertyName = "Adultes.Prenom";
			InitialiseCombos();

			cboFolders.KeyDown += EnterPressed;
			txtFirstName.KeyDown += EnterPressed;
			txtFirstName.KeyDown += EnterPressed;
			txtRechercheTelephone.KeyDown += EnterPressed;
		}

		/// <summary>
		/// Initialisation du combobox des enfants
		/// </summary>
		private void InitialiseCombos()
		{
			cboFolders.DataSource = Connexion.Instance().Dossier.ToList();
			cboFolders.DisplayMember = ResourcesString.STR_Dossier_ID;
			cboFolders.ValueMember = ResourcesString.STR_Dossier_ID;
			cboFolders.SelectedValue = -1;
		}

		private void btnAddCommunication_Click(object sender, EventArgs e)
		{
			//Nouvelle communication
			communication = new Communication();
			communication.FormClosing += new FormClosingEventHandler(UpdateDataSource);
			communication.CommunicationAdded += new EventHandler<Entities.Communication>(CommunicationAdded);
			communication.Show();
		}

		/// <summary>
		/// Met à jour le datasource
		/// </summary>
		private void UpdateDataSource(object sender, EventArgs e)
		{
			Init();
		}

		private void CommunicationAdded(object sender, Entities.Communication e)
		{
			if (((Entities.Dossier)bsData.Current).Dossier_ID.Equals(e.Dossier_ID))
			{
				bsDataCommunication.DataSource = Connexion.Instance().Communication.Where(x => x.Dossier_ID.Equals(e.Dossier_ID)).OrderByDescending(c => c.DateComm).ToList();
			}
		}

		/// <summary>
		/// Survient lors du changement d'un dossier
		/// </summary>
		private void FolderEntityUpdated(object sender, Entities.Dossier e)
		{

		}

		/// <summary>
		/// Sur le double click sur une row
		/// </summary>
		private void gvCommunications_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = gvCommunications.CurrentRow;
			communication = new Communication((Entities.Communication)row.DataBoundItem);
			communication.CommunicationAdded += new EventHandler<Entities.Communication>(CommunicationAdded);
			communication.Show();
		}

		/// <summary>
		/// Survient lors du double click sur un dossier
		/// </summary>
		private void gvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = gvList.CurrentRow;
			DossierNouveau = new DossierNouveau((Entities.Dossier)row.DataBoundItem);
			//DossierNouveau.CommunicationAdded += new EventHandler<Entities.Communication>(CommunicationAdded);
			DossierNouveau.Show();
		}

		private void gvList_SelectionChanged(object sender, EventArgs e)
		{
			OnGvListSelectionChanged();
		}

		private void OnGvListSelectionChanged()
		{
			DataGridViewRow row = gvList.CurrentRow;
			if (row == null) return;

			CurrentDossier = (Entities.Dossier)row.DataBoundItem;
			var communications = Connexion.Instance().Communication.Where(x => x.Dossier_ID.Equals(CurrentDossier.Dossier_ID)).ToList();
			bsDataCommunication.DataSource = communications.OrderByDescending(x => x.DateComm);
			var kids = Connexion.Instance().Enfants.Where(x => x.Dossier_ID == CurrentDossier.Dossier_ID).OrderBy(o => o.Naissance).ToList();
			bsDataKids.DataSource = kids;

			var parents = CurrentDossier.Adultes.SelectMany(x => x.Parent).ToList();
			bsDataParents.DataSource = parents;
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

		private void btnClearFilters_Click(object sender, EventArgs e)
		{
			txtFirstName.Text = txtLastName.Text = txtRechercheTelephone.Text = "";
			cboFolders.SelectedValue = -1;
		}

		private void btnSaveDossier_Click(object sender, EventArgs e)
		{
			AssignValues();
			connexionActions.Update(CurrentDossier);
			var result = MessageBox.Show(ResourcesString.STR_MessageUpdateConfirmation1 + "du dossier" + ResourcesString.STR_MessageUpdateConfirmation2,
			ResourcesString.STR_TitleUpdateConfirmation,
			MessageBoxButtons.OK, MessageBoxIcon.Information);
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
			e.ContextMenuStrip = contextMenu;
			rownum = e.RowIndex;
		}

		private void addRow_Click(object sender, EventArgs e)
		{

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

		private void btnAddFolder_Click(object sender, EventArgs e)
		{
			m_NewDossier = new DossierNouveau();
			m_NewDossier.FormClosing += new FormClosingEventHandler(UpdateDataSource);
			m_NewDossier.ShowDialog();
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

	}
}


