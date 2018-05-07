using System;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using ProjetMFTR.DataAccess;
using ProjetMFTR.Resources;

namespace ProjetMFTR
{
	public partial class Accueil : Form
	{

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
			Suivi suivi = new Suivi();
			suivi.Show();
		}

		private void btnRecherche_Click(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// Supression de suivis
		/// </summary>
		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (gvList.SelectedRows.Count == 0){ return; }

			DialogResult result = MessageBox.Show(string.Format("Êtes-vous sur de vouloir supprimer ces {0} suivi(s) ?", gvList.SelectedRows.Count),
			"Confirmation de suppression",
			MessageBoxButtons.YesNo);

			if (result.Equals(DialogResult.No)) { return; }

			//Connexion.Instance().Suivis.RemoveRange((Entities.Suivis)gvList.SelectedRows);
			//Connexion.Instance().SaveChanges();
			//gvList.DataSource = Connexion.Instance().Suivis.ToList();	
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
		#endregion

		#region Methods

		/// <summary>
		/// Initialisation du combobox des enfants
		/// </summary>
		private void InitialiseCombos()
		{
			cboKid.DataSource = Connexion.Instance().Enfants.ToList();
			cboKid.DisplayMember = ResourcesString.STR_Name;
			cboKid.ValueMember = ResourcesString.STR_Id;
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
