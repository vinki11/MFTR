using ProjetMFTR.DataAccess;
using ProjetMFTR.DbConnexion.Helper;
using ProjetMFTR.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetMFTR.Forms
{
	public partial class DossierNouveau : Form
	{
		#region Members

		Entities.Dossier CurrentDossier;
        EditMode editMode;
        Connexion.ConnexionActions<Entities.Dossier> connexionActions = new Connexion.ConnexionActions<Entities.Dossier>();

		#endregion

		public DossierNouveau()
		{
			InitializeComponent();
			Init();
            //editMode = EditMode.New;
            nouveau();
        }

		public DossierNouveau(Entities.Dossier dossier) : this()
		{
			AssignFolder(dossier);
            editMode = EditMode.Edit;
            this.Text = "Modification d'un dossier";
        }

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void rtxtRemarque_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnSaveAndQuit_Click(object sender, EventArgs e)
		{
			Save();
			Close();
		}

		private void Init()
		{
			listParents.Columns["Nom"].DataPropertyName = "Adultes.Nom";
			listParents.Columns["SubName"].DataPropertyName = "Adultes.Prenom";
		}

		/// <summary>
		/// Sauvegarde le dossier
		/// </summary>
		private Boolean Save()
		{
            //Valider si un dossier existe déja avec ce numéro si on est en mode ajout

			CurrentDossier = new Entities.Dossier();
			CurrentDossier.Dossier_ID = this.txtNoDossier.Text;
			CurrentDossier.Ouverture = this.dtpDateOuverture.Value.Date;
			CurrentDossier.Actif = "0"; //T'es sérieux la que la colonne est en String pi que c'est des 0 et -1
			CurrentDossier.Remarque = this.rtxtRemarque.Text;
			CurrentDossier.Type = this.cboType.Text;


			connexionActions.Add(CurrentDossier);
			DialogResult result = MessageBox.Show("Le dossier " + CurrentDossier.Dossier_ID + ResourcesString.STR_MessageAddConfirmation,
							 ResourcesString.STR_TitleAddConfirmation,
							 MessageBoxButtons.OK, MessageBoxIcon.Information);

			return true;
		}

		private void AssignFolder(Entities.Dossier dossier)
		{
			txtNoDossier.Text = Connexion.Instance().Dossier.FirstOrDefault(x => x.Dossier_ID == dossier.Dossier_ID).Dossier_ID;
			cboType.Text = dossier.Type;
			dtpDateOuverture.Value = dossier.Ouverture.HasValue ? dossier.Ouverture.Value : DateTime.MinValue;

			var kids = Connexion.Instance().Enfants.Where(x => x.Dossier_ID == dossier.Dossier_ID).OrderBy(o => o.Naissance).ToList();
			bsDataKids.DataSource = kids;

			var parents = dossier.Adultes.SelectMany(x => x.Parent).ToList();
			bsDataParents.DataSource = parents;
			CurrentDossier = dossier;

			rtxtRemarque.Text = dossier.Remarque;
		}

		private void AssignValues()
		{

		}

		private void btnSaveAndNew_Click(object sender, EventArgs e)
		{
            Save();
            nouveau();
        }

        private void nouveau()
        {
            this.Text = "Nouveau dossier";
            CurrentDossier = null;

            this.txtNoDossier.Text = "";
            this.dtpDateOuverture.Value = DateTime.Today;
            this.rtxtRemarque.Text = "";
            this.cboType.SelectedIndex = 0;
            editMode = EditMode.New;

        }

        private void listParents_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			try
			{
				if ((listParents.Rows[e.RowIndex].DataBoundItem != null) &&
								(listParents.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
				{
					e.Value = Helper.BindProperty(
												listParents.Rows[e.RowIndex].DataBoundItem,
												listParents.Columns[e.ColumnIndex].DataPropertyName
											);
				}
			}
			catch (Exception)
			{

				return;
			}
		}

        private enum EditMode
        {
            New = 1,
            Edit = 2
        };
        
    }
}
