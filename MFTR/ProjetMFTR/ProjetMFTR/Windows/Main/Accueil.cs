using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using ProjetMFTR.DataAccess;
using System.Linq;
using ProjetMFTR.Windows.Payments;

namespace ProjetMFTR.Forms
{
	public partial class Accueil : MetroFramework.Forms.MetroForm
	{
		List<Entities.Dossier> folders;
		List<Entities.Suivi> suivis;
		bool firstOpeningFolder = true;
		bool firstOpeningSuivis = true;
		Thread thread;

		public Accueil()
		{
			folders = new List<Entities.Dossier>();
			suivis = new List<Entities.Suivi>();

			thread = new Thread(new ThreadStart(Loading));
			thread.Start();
			Connexion.Instance();
			Initialize();
			InitializeComponent();
			Thread.Sleep(2000);
			thread.Abort();
		}

		public async void Initialize()
		{
			folders = await Connexion.connexionActions.GetAllAsync();
			folders = folders.OrderByDescending(x => x.Ouverture).ToList();

			suivis = await Connexion.connexionActionsSuivi.GetAllAsync();
			suivis = suivis.OrderByDescending((x) => x.dateSuivi).ThenByDescending(p => p.suivi_id).ToList();

			var b = Connexion.BCEngine;
		}

		///// <summary>
		/// Chargement de la fenêtre splashscreen
		/// </summary>
		private void Loading()
		{
			frmSplashScreen frm = new frmSplashScreen();
			try
			{
				Application.Run(frm);
			}
			catch
			{
				thread.Join();
			}
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

			using (Login frm = new Login())
			{
				frm.ShowDialog();

				if (!frm.ConnexionAccepted) { return; }
			}

			Communication communication = new Communication();
			communication.Show();
		}

		/// <summary>
		/// Accède à la form de gestion des dossiers
		/// </summary>
		private void btnGestionDossier_Click(object sender, EventArgs e)
		{
			TopMost = false;

			using (Login frm = new Login())
			{
				frm.ShowDialog();

				if (!frm.ConnexionAccepted) { return; }
			}

			if (!firstOpeningFolder) { folders = Connexion.Instance().Dossier.OrderByDescending((x) => x.Ouverture).ToList(); }

			Dossier dossier = new Dossier(folders);
			dossier.Show();

			firstOpeningFolder = false;
		}

		/// <summary>
		/// Accède à la form de gestion des intervenants
		/// </summary>
		private void btnGestionIntervenant_Click(object sender, EventArgs e)
		{
			TopMost = false;

			using (Login frm = new Login())
			{
				frm.ShowDialog();

				if (!frm.ConnexionAccepted) { return; }
			}

			Intervenant intervenantForm = new Intervenant();
			intervenantForm.Show();
		}

		/// <summary>
		/// Accède à la form de gestion des suivis
		/// </summary>
		private void btnGestionSuivi_Click(object sender, EventArgs e)
		{
			TopMost = false;

			using (Login frm = new Login())
			{
				frm.ShowDialog();

				if (!frm.ConnexionAccepted) { return; }
			}

			if (!firstOpeningSuivis) { suivis = Connexion.Instance().Suivi.OrderByDescending((x) => x.dateSuivi).ThenByDescending(p => p.suivi_id).ToList(); }

			SuivisList suiviListtForm = new SuivisList(suivis);
			suiviListtForm.Show();

			firstOpeningSuivis = false;
		}

		private void btnOptions_Click(object sender, EventArgs e)
		{
			TopMost = false;

			using (Login frm = new Login())
			{
				frm.ShowDialog();

				if (!frm.ConnexionAccepted) { return; }
			}

			Options options = new Options();
			options.Show();
		}

		#endregion Handlers

		private void btnPassage_Click(object sender, EventArgs e)
		{
			TopMost = false;

			using (Login frm = new Login())
			{
				frm.ShowDialog();

				if (!frm.ConnexionAccepted) { return; }
			}

			Options options = new Options();
			options.Show();
		}

		private void btnPayment_Click(object sender, EventArgs e)
		{
			TopMost = false;

			using (Login frm = new Login())
			{
				frm.ShowDialog();

				if (!frm.ConnexionAccepted) { return; }
			}

			Payment payment = new Payment();
			payment.Show();

		}
	}
}