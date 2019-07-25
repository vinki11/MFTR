using System;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace ProjetMFTR.Forms
{
	public partial class Accueil : MetroFramework.Forms.MetroForm
	{
		public Accueil()
		{
			Thread thread = new Thread(new ThreadStart(Loading));
			thread.Start();
			InitializeComponent();
			Thread.Sleep(2000);
			thread.Abort();
		}

		/// <summary>
		/// Chargement de la fenêtre splashscreen
		/// </summary>
		private void Loading()
		{
			frmSplashScreen frm = new frmSplashScreen();
			Application.Run(frm);
		}

		#region Handlers

		private void Accueil_Load(object sender, EventArgs e)
		{
			BringToFront();
			Activate();
			lblVersion.Text += Assembly.GetExecutingAssembly().GetName().Version;
		}

		/// <summary>
		/// Accède à la fenêtre des communications
		/// </summary>
		private void btnCommunication_Click(object sender, EventArgs e)
		{
			TopMost = false;
			Communication communication = new Communication();
			communication.Show();
		}

		/// <summary>
		/// Accède à la form de gestion des dossiers
		/// </summary>
		private void btnGestionDossier_Click(object sender, EventArgs e)
		{
			TopMost = false;
			Dossier dossier = new Dossier();
			dossier.Show();
		}

		/// <summary>
		/// Accède à la form de gestion des intervenants
		/// </summary>
		private void btnGestionIntervenant_Click(object sender, EventArgs e)
		{
			TopMost = false;
			Intervenant intervenantForm = new Intervenant();
			intervenantForm.Show();
		}

		/// <summary>
		/// Accède à la form de gestion des suivis
		/// </summary>
		private void btnGestionSuivi_Click(object sender, EventArgs e)
		{
			TopMost = false;
			SuivisList suiviListtForm = new SuivisList();
			suiviListtForm.Show();
		}

		private void btnOptions_Click(object sender, EventArgs e)
		{
			TopMost = false;
			Options options = new Options();
			options.Show();
		}

		#endregion Handlers
	}
}