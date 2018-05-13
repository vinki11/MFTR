using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using ProjetMFTR.DataAccess;
using ProjetMFTR.DbConnexion.Helper;
using ProjetMFTR.Resources;
using ProjetMFTR.Forms;

namespace ProjetMFTR
{
	public partial class Accueil : Form
	{
		#region Members

		private Suivi m_Suivi;
		#endregion
		#region Constructors

		/// <summary>
		/// Constructeur de la classe
		/// </summary>
		public Accueil()
		{
			Thread thread = new Thread(new ThreadStart(Splash));
			thread.Start();
			InitializeComponent();
			//Initialisation des combosbox
			Init();
			InitialiseCombos();
			thread.Abort();
		}

		#endregion

		#region Events

		/// <summary>
		/// Ajout d'un nouveau suivi
		/// </summary>
		private void btnAdd_Click(object sender, EventArgs e)
		{
			m_Suivi = new Suivi();
			m_Suivi.FormClosing += new FormClosingEventHandler(m_Suivi_Closing);
			m_Suivi.Show();
		}

		private void m_Suivi_Closing(object sender, EventArgs e) 
		{
			Init();
		}

		private void btnRecherche_Click(object sender, EventArgs e)
		{
			string dossier = null;
			int? enfant = null;
			List<Entities.Suivi> suivis = Connexion.Instance().Suivi.ToList();

			if (chkDate.Checked)
			{
				suivis = suivis.Where((x) => x.dateSuivi.Equals(dtpDate.Value.Date)).ToList();
			}

			if (cboFolders.SelectedValue != null)
			{
				dossier = ((Entities.Dossier)cboFolders.SelectedItem).Dossier_ID;
				suivis = suivis.Where((x) => x.dossier_id.Equals(dossier)).ToList();
			}

			if (cboKid.SelectedValue != null)
			{
				enfant = ((Entities.Enfants)cboKid.SelectedItem).Enfant_ID;
				suivis = suivis.Where((x) => x.enfant_id.Equals(enfant)).ToList();

			}

			bsData.DataSource = null;
			bsData.DataSource = suivis;
		}

		/// <summary>
		/// Supression de suivis
		/// </summary>
		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (gvList.SelectedRows.Count == 0 && gvList.CurrentRow == null) { return; }

			DialogResult result = MessageBox.Show(string.Format("Êtes-vous sur de vouloir supprimer {0} suivi(s) ?", gvList.SelectedRows.Count == 0 ? 1 : gvList.SelectedRows.Count),
			"Confirmation de suppression",
			MessageBoxButtons.YesNo);

			if (result.Equals(DialogResult.No)) { return; }

			DataGridViewSelectedRowCollection rows = gvList.SelectedRows;
			try
			{
			foreach (DataGridViewRow row in rows) { Connexion.Instance().Suivi.Remove((Entities.Suivi)row.DataBoundItem); }
			}
			catch(Exception ee)
			{
				Connexion.Instance().Dispose();
				return;
			}
			Connexion.Instance().SaveChanges();
			bsData.DataSource = null;
			bsData.DataSource = Connexion.Instance().Suivi.ToList();
		}

		/// <summary>
		/// Accède à la form de gestion des intervenants
		/// </summary>
		private void btnGestion_Click(object sender, EventArgs e)
		{
            Intervenant intervenantForm = new Intervenant();
            intervenantForm.Show();
        }

		/// <summary>
		/// Impression
		/// </summary>
		private void btnPrint_Click(object sender, EventArgs e)
		{

		}


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

			Suivi s = new Suivi((Entities.Suivi)row.DataBoundItem);
			s.Show();
		}

		private void chkDate_CheckedChanged(object sender, EventArgs e)
		{
			dtpDate.Enabled = chkDate.Checked;
		}
		#endregion

		#region Methods

		/// <summary>
		/// Initialisation de la grille des suivis
		/// </summary>
		private void Init()
		{
			bsData.DataSource = Connexion.Instance().Suivi.ToList();
			gvList.Columns["Dossier"].DataPropertyName = "Dossier.Dossier_ID";
			gvList.Columns["Enfant"].DataPropertyName = "Enfants.Name";
			gvList.Columns["Intervenant"].DataPropertyName = "Intervenant.prenom";

		}

		/// <summary>
		/// Initialisation du combobox des enfants
		/// </summary>
		private void InitialiseCombos()
		{
			cboKid.DataSource = Connexion.Instance().Enfants.ToList();
			cboKid.DisplayMember = ResourcesString.STR_Name;
			cboKid.ValueMember = ResourcesString.STR_EnfantId;
			cboKid.SelectedValue = -1;

			cboFolders.DataSource = Connexion.Instance().Dossier.ToList();
			cboFolders.DisplayMember = ResourcesString.STR_Dossier_ID;
			cboFolders.ValueMember = ResourcesString.STR_Dossier_ID;
			cboFolders.SelectedValue = -1;
		}


		void Splash()
		{
			SplashScreen.SplashForm frm = new SplashScreen.SplashForm();
			frm.AppName = "Maison de la famille";
			frm.Icon = Properties.Resources.icone_MFTR;
			frm.ShowIcon = true;
			frm.ShowInTaskbar = true;
			frm.Controls.OfType<Label>().Where((x) => x.Name.Equals("lStatusInfo")).FirstOrDefault().Width = 300;
			frm.Controls.OfType<Label>().Where((x) => x.Name.Equals("lStatusInfo")).FirstOrDefault().Text = "Chargement...";
			try
			{
			Application.Run(frm);
			}
			catch(Exception e)
			{
				frm.Close();
			}
		}

		#endregion

	}
}
