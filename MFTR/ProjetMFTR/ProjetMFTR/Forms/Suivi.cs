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

		void CombosInitialisation()
		{
			cboFolders.DataSource = Connexion.Instance().Dossier.ToList();
			cboFolders.DisplayMember = ResourcesString.STR_Dossier_ID;
			cboFolders.ValueMember = ResourcesString.STR_Dossier_ID;

			cboKids.DataSource = Connexion.Instance().Enfants.ToList();
			cboKids.DisplayMember = ResourcesString.STR_Name;
			cboKids.ValueMember = ResourcesString.STR_Id;
		}

		private void btnSaveAndNew_Click(object sender, EventArgs e)
		{
			//Save
			//Clean

		}

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
	}
}
