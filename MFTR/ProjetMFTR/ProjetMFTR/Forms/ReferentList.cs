using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ProjetMFTR.DataAccess;
using ProjetMFTR.DbConnexion.Helper;
using ProjetMFTR.Forms;
using ProjetMFTR.Resources;

namespace ProjetMFTR
{
	public partial class ReferentList : Form
	{
		#region Members

		private Referent m_Referent;

		#endregion Members

		#region Constructors

		/// <summary>
		/// Constructeur de la classe
		/// </summary>
		public ReferentList()
		{
			InitializeComponent();
			//Initialisation des combosbox
			Init();
			InitialiseCombos();
		}

		#endregion Constructors

		#region Events

		/// <summary>
		/// Ajout d'un nouveau suivi
		/// </summary>
		//private void btnAdd_Click(object sender, EventArgs e)
		//{
		//	m_Suivi = new Suivi();
		//	m_Suivi.FormClosing += new FormClosingEventHandler(UpdateDataSource);
		//	m_Suivi.Show();
		//}

		private void UpdateDataSource(object sender, EventArgs e)
		{
			Init();
			cboReferent.DataSource = Connexion.Instance().Referent.OrderBy((x) => x.Referent_ID).ToList();
		}

		private void btnRecherche_Click(object sender, EventArgs e)
		{
			List<Entities.Referent> referents = Connexion.Instance().Referent.ToList();

			if (cboReferent.SelectedValue != null)
			{
				referents = referents.Where(x => x.Referent_ID == ((Entities.Referent)cboReferent.SelectedItem).Referent_ID).ToList();
			}

			bsData.DataSource = null;
			bsData.DataSource = referents.ToList();
		}

		/// <summary>
		/// Supression de suivis
		///// </summary>
		//private void btnDelete_Click(object sender, EventArgs e)
		//{
		//	if (gvList.SelectedRows.Count == 0 && gvList.CurrentRow == null) { return; }

		//	DialogResult result = MessageBox.Show(string.Format("Êtes-vous sur de vouloir supprimer {0} suivi(s) ?", gvList.SelectedRows.Count == 0 ? 1 : gvList.SelectedRows.Count),
		//	"Confirmation de suppression",
		//	MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

		//	if (result.Equals(DialogResult.No)) { return; }

		//	DataGridViewSelectedRowCollection rows = gvList.SelectedRows;
		//	try
		//	{
		//		foreach (DataGridViewRow row in rows) { Connexion.Instance().Suivi.Remove((Entities.Suivi)row.DataBoundItem); }
		//	}
		//	catch (Exception ee)
		//	{
		//		Connexion.Instance().Dispose();
		//		return;
		//	}
		//	Connexion.Instance().SaveChanges();
		//	Init();
		//}

		//}
		/// <summary>
		/// Survient au formatage des cellules
		/// </summary>
		private void gvList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if ((gvList.Rows[e.RowIndex].DataBoundItem != null) &&
		 (gvList.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
			{
				e.Value = Helper.BindProperty(
											gvList.Rows[e.RowIndex].DataBoundItem,
											gvList.Columns[e.ColumnIndex].DataPropertyName
										);
			}
		}

		/// <summary>
		/// Sur le double click sur une row
		/// </summary>
		private void gvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = gvList.CurrentRow;
			if (row == null) { return; }
			m_Referent = new Referent((Entities.Referent)row.DataBoundItem);
			m_Referent.ReferentAdded += new EventHandler(UpdateDataSource);
			m_Referent.Show();
		}

		private void btnClearFilters_Click(object sender, EventArgs e)
		{
			cboReferent.SelectedValue = -1;
		}

		#endregion Events

		#region Methods

		/// <summary>
		/// Initialisation de la grille des suivis
		/// </summary>
		private void Init()
		{
			bsData.DataSource = Connexion.Instance().Referent.OrderBy((x) => x.Referent_ID).ToList();
			gvList.Columns["Nom"].DataPropertyName = "Adultes.Nom";
			gvList.Columns["Prenom"].DataPropertyName = "Adultes.Prenom";

			cboReferent.KeyDown += EnterPressed;
		}

		/// <summary>
		/// Initialisation du combobox
		/// </summary>
		private void InitialiseCombos()
		{
			cboReferent.DataSource = Connexion.Instance().Referent.OrderBy((x) => x.Referent_ID).ToList();
			cboReferent.DisplayMember = ResourcesString.STR_ReferentId;
			cboReferent.ValueMember = ResourcesString.STR_ReferentId;
			cboReferent.SelectedValue = -1;
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

		#endregion Methods

		private void btnAdd_Click(object sender, EventArgs e)
		{
			m_Referent = new Referent();
			m_Referent.FormClosing += new FormClosingEventHandler(UpdateDataSource);
			m_Referent.Show();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (gvList.SelectedRows.Count == 0 && gvList.CurrentRow == null) { return; }

			DialogResult result = MessageBox.Show(string.Format("Êtes-vous sur de vouloir supprimer {0} référent(s) ?", gvList.SelectedRows.Count == 0 ? 1 : gvList.SelectedRows.Count),
			"Confirmation de suppression",
			MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (result.Equals(DialogResult.No)) { return; }

			DataGridViewSelectedRowCollection rows = gvList.SelectedRows;
			try
			{
				foreach (DataGridViewRow row in rows) { Connexion.Instance().Referent.Remove((Entities.Referent)row.DataBoundItem); }
			}
			catch (Exception ee)
			{
				Connexion.Instance().Dispose();
				return;
			}
			Connexion.Instance().SaveChanges();
			Init();
		}

		private void gvList_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
		{
			e.ContextMenuStrip = ContextMenu;
		}
	}
}