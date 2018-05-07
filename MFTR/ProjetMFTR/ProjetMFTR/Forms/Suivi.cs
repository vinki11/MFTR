using System;
using System.Linq;
using System.Windows.Forms;
using ProjetMFTR.DataAccess;
using ProjetMFTR.Resources;

namespace ProjetMFTR
{
	public partial class Suivi : Form
	{

		public Suivi()
		{
			InitializeComponent();
			CombosInitialisation();
		}

		/// <summary>
		/// Initialisation des combos box
		/// </summary>
		void CombosInitialisation()
		{
			cboFolders.DataSource = Connexion.Instance().Dossier.ToList();
			cboFolders.DisplayMember = ResourcesString.STR_Dossier_ID;
			cboFolders.ValueMember = ResourcesString.STR_Dossier_ID;

			cboKids.DataSource = Connexion.Instance().Enfants.ToList();
			cboKids.DisplayMember = ResourcesString.STR_Name;
			cboKids.ValueMember = ResourcesString.STR_EnfantId;

			cboEmployes.DataSource = Connexion.Instance().Intervenant.Where((x) => x.actif == 1).ToList();
			cboEmployes.DisplayMember = ResourcesString.STR_Prenom;
			cboEmployes.ValueMember = ResourcesString.STR_IntervenantId;
		}

		/// <summary>
		/// Sauvegarde et création d'un nouveau suivi
		/// </summary>
		private void btnSaveAndNew_Click(object sender, EventArgs e)
		{
			//Save
			//Clean

		}

		/// <summary>
		/// Sauvegarde
		/// </summary>
		private void btnSave_Click(object sender, EventArgs e)
		{
			if (((Entities.Dossier)cboFolders.SelectedItem) == null)
			{
				MessageBox.Show("Vous devez sélectionner un dossier pour pouvoir sauvegarder le suivi",
				"Attention",
				MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				return;
			}

			if (((Entities.Enfants)cboKids.SelectedItem) == null)
			{
				MessageBox.Show("Vous devez sélectionner un enfant pour pouvoir sauvegarder le suivi",
				"Attention",
				MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			if (((Entities.Intervenant)cboEmployes.SelectedItem) == null)
			{
				MessageBox.Show("Vous devez sélectionner un intervenant pour pouvoir sauvegarder le suivi",
				"Attention",
				MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}


			//Save
			//Exemple d'ajout à la DB

			Entities.Suivi suivi = new Entities.Suivi()
			{
				enfant_id = ((Entities.Enfants)cboKids.SelectedItem).Enfant_ID,
				dossier_id = ((Entities.Dossier)cboFolders.SelectedItem).Dossier_ID,
				dateSuivi = dtpDateSuivi.Value,
				intervenant_id = ((Entities.Intervenant)cboEmployes.SelectedItem).intervenant_id,
				remarque = rtxtRemarque.Text,
				moment = cboMoment.Text
			};
			Connexion.Instance().Suivi.Add(suivi);
			Connexion.Instance().SaveChanges();
		}

		/// <summary>
		/// Affecter les enfants selon le dossier sélectionné
		/// </summary>
		private void cboFolders_SelectedIndexChanged(object sender, EventArgs e)
		{
			cboKids.DataSource = Connexion.Instance().Enfants.Where((x) => x.Dossier_ID.Equals(((Entities.Dossier)cboFolders.SelectedItem).Dossier_ID)).ToList();
		}
	}
}
