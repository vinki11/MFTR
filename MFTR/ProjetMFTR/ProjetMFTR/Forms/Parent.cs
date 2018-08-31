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
    public partial class Parent : Form
    {
        #region Members

        Entities.Parent CurrentParent;
        Entities.Adultes CurrentAdulte;
        String CurrentDossierID;
        EditMode editMode;
        Connexion.ConnexionActions<Entities.Adultes> connexionActionsAdulte = new Connexion.ConnexionActions<Entities.Adultes>();
        Connexion.ConnexionActions<Entities.Parent> connexionActionsParent = new Connexion.ConnexionActions<Entities.Parent>();

        #endregion

        public Parent(string dossierId)
        {
            InitializeComponent();
            CurrentDossierID = dossierId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            save();
        }

        private void save()
        {
            //Si nouveau Parent
            CurrentAdulte = new Entities.Adultes();
            CurrentParent = new Entities.Parent();

            CurrentAdulte.Dossier_ID = CurrentDossierID;
            CurrentAdulte.Nom = this.txtNom.Text;
            CurrentAdulte.Prenom = this.txtPrenom.Text;

            connexionActionsAdulte.Add(CurrentAdulte);

            CurrentParent.Adultes = CurrentAdulte;
            CurrentParent.Adulte_ID = 1; //Aller chercher l'id qu'on vient d'ajouter
            CurrentParent.Naissance = this.dtpNaissance.Value.Date;
            CurrentParent.Statut = this.cboStatut.SelectedItem.ToString();
            CurrentParent.Sexe = this.cboSexe.SelectedItem.ToString();


            connexionActionsParent.Add(CurrentParent);
            DialogResult result = MessageBox.Show("Le parent " + CurrentAdulte.Prenom + " " + CurrentAdulte.Nom + ResourcesString.STR_MessageAddConfirmation,
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
