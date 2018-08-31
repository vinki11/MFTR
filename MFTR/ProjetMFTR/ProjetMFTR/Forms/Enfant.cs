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
    public partial class Enfant : Form
    {
        #region Members

        Entities.Enfants CurrentEnfant;
        String CurrentDossierID;
        EditMode editMode;
        Connexion.ConnexionActions<Entities.Enfants> connexionActions = new Connexion.ConnexionActions<Entities.Enfants>();

        #endregion

        public Enfant(string dossierID)
        {
            InitializeComponent();
            CurrentDossierID = dossierID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            save();
        }

        private void save()
        {
            CurrentEnfant = new Entities.Enfants();
            CurrentEnfant.Dossier_ID = CurrentDossierID;
            CurrentEnfant.Naissance = this.dtpNaissance.Value.Date;
            CurrentEnfant.Nom = this.txtNom.Text;
            CurrentEnfant.Prenom = this.txtPrenom.Text;
            CurrentEnfant.Accueil = this.cboStatut.SelectedIndex == 1 ? false : true;
            CurrentEnfant.Sexe = this.cboSexe.SelectedItem.ToString();


            connexionActions.Add(CurrentEnfant);
            DialogResult result = MessageBox.Show("L'enfant " + CurrentEnfant.Prenom + " " + CurrentEnfant.Nom + ResourcesString.STR_MessageAddConfirmation,
                             ResourcesString.STR_TitleAddConfirmation,
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private enum EditMode
        {
            New = 1,
            Edit = 2
        };

    }
}
