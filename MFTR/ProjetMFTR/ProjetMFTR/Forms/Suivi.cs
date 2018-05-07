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
			cboKids.ValueMember = ResourcesString.STR_Id;
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
			//Save
			//Exemple d'ajout à la DB

			//Entities.Enfants enfants = new Entities.Enfants()
			//{
			//	Nom = "Test_enfant"
			//};
			//Connexion.Instance().Enfants.Add(enfants);
			//Connexion.Instance().SaveChanges();
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
