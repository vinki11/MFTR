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
			Thread thread = new Thread(new ThreadStart(Spash));
			thread.Start();
			//Thread.Sleep(6000);
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

		private void btnDelete_Click(object sender, EventArgs e)
		{

		}

		private void btnGestion_Click(object sender, EventArgs e)
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
			//Connexion.Instance().Database.BeginTransaction();

		}


		void Spash()
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
