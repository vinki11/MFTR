using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetMFTR.Forms
{
	public partial class Accueil1 : MetroFramework.Forms.MetroForm
	{
		public Accueil1()
		{
			Thread thread = new Thread(new ThreadStart(Loading));
			thread.Start();
			InitializeComponent();
			Thread.Sleep(2000);
			thread.Abort();
		}

		void Loading()
		{
			frmSplashScreen frm = new frmSplashScreen();
			Application.Run(frm);
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
		/// Accède à la fenêtre des communications
		/// </summary>
		private void button1_Click(object sender, EventArgs e)
		{
			TopMost = false;
			Communication communication = new Communication();
			communication.Show();
		}
	}
}
