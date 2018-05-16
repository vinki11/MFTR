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
    public partial class Intervenant : Form
    {
        Entities.Intervenant currentIntervenant;
        Connexion.ConnexionUpdater<Entities.Intervenant> connexionUpdater = new Connexion.ConnexionUpdater<Entities.Intervenant>();
        EditMode editMode;

        public Intervenant()
        {
            InitializeComponent();
            loadCbIntervenant();
            editMode = EditMode.Edit;
        }

        private void Intervenant_Load(object sender, EventArgs e)
        {

        }

        private void selectIntervenant()
        {
            if (currentIntervenant != null)
            {
                toggleChamps(false);
                this.txtNom.Text = currentIntervenant.nom;
                this.chbActif.CheckState = (CheckState)currentIntervenant.actif;
            }
            else
            {
                clearNom();
                toggleChamps(true);
            }
        }

        private void loadCbIntervenant()
        {
            currentIntervenant = null;
            clearNom();
            toggleChamps(true);
            List<Entities.Intervenant> intervenants = Connexion.Instance().Intervenant.ToList();

            if (!chkInactifs.Checked)
            {
                //On affiche seulement les intervenants actifs
                intervenants = intervenants.Where((x) => x.actif.Equals(1)).ToList();
            }
            else
            {
                //On affiche seulement les inactifs
                intervenants = intervenants.Where((x) => x.actif.Equals(0)).ToList();
            }

            cboIntervenant.Text = "";
            cboIntervenant.DataSource = intervenants;
            cboIntervenant.DisplayMember = ResourcesString.STR_Nom;
            cboIntervenant.ValueMember = ResourcesString.STR_IntervenantId;
            cboIntervenant.SelectedValue = -1;
        }

        private void chkInactifs_CheckedChanged(object sender, EventArgs e)
        {
            loadCbIntervenant();
        }

        private void cboIntervenant_SelectionChangeCommitted(object sender, EventArgs e)
        {
            currentIntervenant = (Entities.Intervenant)cboIntervenant.SelectedItem;
            selectIntervenant();
        }

        private enum EditMode
        {
            New = 1,
            Edit = 2
        };

        private void toggleChamps(bool readOnly)
        {
            this.txtNom.ReadOnly = readOnly;
        }

        private void clearNom()
        {
            this.txtNom.Text = "";
            this.chbActif.CheckState = CheckState.Unchecked;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            toggleChamps(false);
            clearNom();
            this.chbActif.CheckState = CheckState.Checked;
            editMode = EditMode.New;

           // this.btnSupprimer.Text = "Annuler";
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (this.txtNom.Text == "")
            {
                DialogResult result = MessageBox.Show(ResourcesString.STR_MessageWarningNomIntervenant,
                ResourcesString.STR_TitleWarningNomIntervenant,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                currentIntervenant.nom = this.txtNom.Text;
                currentIntervenant.actif = (int)this.chbActif.CheckState;

                if (editMode == EditMode.Edit)
                {
                    connexionUpdater.Update(currentIntervenant);
                    DialogResult result = MessageBox.Show(ResourcesString.STR_MessageUpdateConfirmation1 + "de l'intervenant" + ResourcesString.STR_MessageUpdateConfirmation2,
                    ResourcesString.STR_TitleUpdateConfirmation,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                loadCbIntervenant();
                editMode = EditMode.Edit;
            }
            
        }

        //private void btnSupprimer_Click(object sender, EventArgs e)
        //{
        //    //On désactive l'intervenant sélectionner dans le menu déroulant
        //    if (editMode == EditMode.Edit)
        //    {
        //        DialogResult result = MessageBox.Show(string.Format("Êtes-vous sur de vouloir supprimer {0} ?", currentIntervenant.nom),
        //        "Confirmation de suppression",
        //        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        //        if (result.Equals(DialogResult.No)) { return; }

        //        currentIntervenant.actif = 0;
        //        connexionUpdater.Update(currentIntervenant);
        //        loadCbIntervenant();
        //        editMode = EditMode.Edit;
        //    }
        //    //On annule ce que l'utilisateur à saisit pour le moment
        //    else if (editMode == EditMode.New)
        //    {
        //        clearNom();
        //    }
        //}
    }
}
