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
	public partial class Accueil : Form
	{
		public Accueil()
		{
			Thread thread = new Thread(new ThreadStart(Splash));
			try
			{
				thread.Start();
				InitializeComponent();
				Thread.Sleep(2000);
				Focus();
				TopMost = true;
			}
			catch (Exception e)
			{
			}
			finally
			{
				thread.Abort();
			}
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
			catch (Exception e)
			{
				Application.ExitThread();
			}
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
