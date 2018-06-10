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
using ProjetMFTR.Resources;

namespace ProjetMFTR.Forms
{
	public partial class Dossier : Form
	{

		#region Members
		Entities.Dossier CurrentDossier;
		Connexion.ConnexionActions<Entities.Dossier> connexionActions = new Connexion.ConnexionActions<Entities.Dossier>();
		#endregion
		public Dossier()
		{
			InitializeComponent();
			Init();
		}

		public void Init()
		{
			bsData.DataSource = Connexion.Instance().Dossier.OrderByDescending((x) => x.Ouverture).ToList();
			InitialiseCombos();
		}

		/// <summary>
		/// Initialisation du combobox des enfants
		/// </summary>
		private void InitialiseCombos()
		{
			cboFolders.DataSource = Connexion.Instance().Dossier.ToList();
			cboFolders.DisplayMember = ResourcesString.STR_Dossier_ID;
			cboFolders.ValueMember = ResourcesString.STR_Dossier_ID;
			cboFolders.SelectedValue = -1;
		}

		private void btnAddCommunication_Click(object sender, EventArgs e)
		{
			//Nouvelle communication
		
		}

		private void gvList_SelectionChanged(object sender, EventArgs e)
		{
			DataGridViewRow row = gvList.CurrentRow;
			CurrentDossier = (Entities.Dossier)row.DataBoundItem;
			var communications = Connexion.Instance().Communication.Where(x => x.Dossier_ID.Equals(CurrentDossier.Dossier_ID)).ToList();
			bsDataCommunication.DataSource = communications.OrderByDescending(x => x.DateComm);
		}

		private void btnRecherche_Click(object sender, EventArgs e)
		{
			string dossier = null;
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
				var adultes = Connexion.Instance().Adultes.ToList();
				var telephones = Connexion.Instance().Telephone.Where(x => x.Telephone1.Equals(txtRechercheTelephone.Text)).ToList();
				var adulte = adultes.Where(x => telephones.Any(v => v.Adulte_ID.Value.Equals(x.Adulte_ID))).ToList();
				dossiers = dossiers.Where(x => adulte.Any(c => c.Dossier_ID.Equals(x.Dossier_ID))).ToList();
			}

			bsData.DataSource = dossiers.OrderByDescending(x => x.Ouverture).ToList();
		}

		private void btnClearFilters_Click(object sender, EventArgs e)
		{
			chkDate.Checked = false;
			cboFolders.SelectedValue = -1;
			txtRechercheTelephone.Text = "";
		}

		private void btnSaveDossier_Click(object sender, EventArgs e)
		{
			AssignValues();
			connexionActions.Update(CurrentDossier);
			var result = MessageBox.Show(ResourcesString.STR_MessageUpdateConfirmation1 + "du dossier" + ResourcesString.STR_MessageUpdateConfirmation2,
			ResourcesString.STR_TitleUpdateConfirmation,
			MessageBoxButtons.OK, MessageBoxIcon.Information);
			//bsData.DataSource = Connexion.Instance().Dossier.OrderByDescending((x) => x.Ouverture).ToList();
		}

		/// <summary>
		/// Assignation des valeurs
		/// </summary>
		private void AssignValues()
		{
			CurrentDossier.Dossier_ID = txtDossier.Text;
			CurrentDossier.Ouverture = dtpDossier.Value.Date;
			CurrentDossier.Type = cboType.Text;
			CurrentDossier.Remarque = rtxtRemarque.Text;
		}
	}
}
