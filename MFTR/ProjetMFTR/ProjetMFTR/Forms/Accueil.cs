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

namespace ProjetMFTR
{
	public partial class Accueil : Form
	{
		#region Members

		private  Suivi m_Suivi;
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

		}

		/// <summary>
		/// Supression de suivis
		/// </summary>
		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (gvList.SelectedRows.Count == 0) { return; }

			DialogResult result = MessageBox.Show(string.Format("Êtes-vous sur de vouloir supprimer {0} suivi(s) ?", gvList.SelectedRows.Count),
			"Confirmation de suppression",
			MessageBoxButtons.YesNo);

			if (result.Equals(DialogResult.No)) { return; }

			DataGridViewSelectedRowCollection rows = gvList.SelectedRows;
			foreach (DataGridViewRow row in rows) { Connexion.Instance().Suivi.Remove((Entities.Suivi)row.DataBoundItem); }

			Connexion.Instance().SaveChanges();
			bsData.DataSource = null;
			bsData.DataSource = Connexion.Instance().Suivi.ToList();
		}

		/// <summary>
		/// Accède à la form de gestion des intervenants
		/// </summary>
		private void btnGestion_Click(object sender, EventArgs e)
		{

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
			Application.Run(frm);
		}

		#endregion

	}
}
