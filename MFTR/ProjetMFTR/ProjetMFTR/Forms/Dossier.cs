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
using ProjetMFTR.Entities;

namespace ProjetMFTR.Forms
{
	public partial class Dossier : Form
	{
		public Dossier()
		{
			InitializeComponent();
			Init();
		}

		public void Init()
		{
			bsData.DataSource = Connexion.Instance().Dossier.OrderByDescending((x) => x.Ouverture).ToList();
		}

		private void btnAddCommunication_Click(object sender, EventArgs e)
		{
			//Nouvelle communication
		
		}

		private void gvList_SelectionChanged(object sender, EventArgs e)
		{
			
		}

		private void btnRecherche_Click(object sender, EventArgs e)
		{
			string dossier = null;
			string telephone = null;
			List<Entities.Dossier> dossiers = Connexion.Instance().Dossier.ToList();

			if (chkDate.Checked)
			{
				dossiers = dossiers.Where((x) => x.Ouverture.Equals(dtpDateRecherche.Value.Date)).ToList();
			}

			if (cboFolders.SelectedValue != null)
			{
				dossier = ((Entities.Dossier)cboFolders.SelectedItem).Dossier_ID;
				dossiers = dossiers.Where((x) => x.Dossier_ID.Equals(dossier)).ToList();
			}

			if (txtRechercheTelephone.Text != "")
			{
				telephone = txtRechercheTelephone.Text;
				List<Entities.Adultes> adultes = new List<Entities.Adultes>();
				List<Entities.Telephone> telephones = new List<Entities.Telephone>();
				telephones = Connexion.Instance().Telephone.Where(x => x.Telephone1.Equals(telephone)).ToList();
				adultes = Connexion.Instance().Adultes.Where(x => telephones.Any(b => b.Adulte_ID.Equals(x.Adulte_ID))).ToList();
				dossiers = dossiers.Where(x => adultes.Any(b => b.Equals(x.Adultes))).ToList();
			}

			bsData.DataSource = dossiers.OrderByDescending(x => x.Ouverture).ToList();
		}
	}
}
