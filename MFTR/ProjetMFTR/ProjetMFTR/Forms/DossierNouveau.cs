using ProjetMFTR.DataAccess;
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
        Connexion.ConnexionActions<Entities.Dossier> connexionActions = new Connexion.ConnexionActions<Entities.Dossier>();

        #endregion

        public DossierNouveau()
        {
            InitializeComponent();
            CurrentDossier = new Entities.Dossier();
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
        }

        /// <summary>
		/// Sauvegarde le dossier
		/// </summary>
		private Boolean Save()
        {
            CurrentDossier.Dossier_ID = this.txtNoDossier.Text;
            CurrentDossier.Ouverture = this.dtpDateOuverture.Value.Date;
            CurrentDossier.Actif = "0"; //T'es sérieux la que la colonne est en String pi que c'est des 0 et -1
            CurrentDossier.Remarque = this.rtxtRemarque.Text;
            CurrentDossier.Type = this.cboType.Text;


            connexionActions.Add(CurrentDossier);
            DialogResult result = MessageBox.Show("Le dossier " + CurrentDossier.Dossier_ID + ResourcesString.STR_MessageAddConfirmation,
                     ResourcesString.STR_TitleAddConfirmation,
                     MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();

            return true;

           
        }
    }
}
