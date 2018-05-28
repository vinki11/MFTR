using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ProjetMFTR.DataAccess;
using ProjetMFTR.Resources;

namespace ProjetMFTR.Forms
{
	public partial class Intervenant : Form
    {
        Entities.Intervenant currentIntervenant;
        Connexion.ConnexionActions<Entities.Intervenant> connexionUpdater = new Connexion.ConnexionActions<Entities.Intervenant>();
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
            this.chbActif.Enabled = !readOnly;
        }

        private void nouveau()
        {
            if (editMode == EditMode.Edit)
            {
                //On créer l'objet currentIntervenant
                currentIntervenant = new Entities.Intervenant();

                cboIntervenant.Text = "";
                toggleChamps(false);
                clearNom();
                this.chkInactifs.Enabled = false;
                this.cboIntervenant.Enabled = false;
                this.chbActif.CheckState = CheckState.Checked;
                editMode = EditMode.New;

                this.btnAjouter.Text = "Annuler";
            }
            else
            {
                currentIntervenant = null;

                toggleChamps(true);
                clearNom();
                this.chkInactifs.Enabled = true;
                this.cboIntervenant.Enabled = true;
                editMode = EditMode.Edit;

                this.btnAjouter.Text = "Ajouter";
            }
        }

        private void clearNom()
        {
            this.txtNom.Text = "";
            this.chbActif.CheckState = CheckState.Unchecked;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            nouveau();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (this.txtNom.Text == "")
            {
                DialogResult result = MessageBox.Show(ResourcesString.STR_MessageWarningNomIntervenant,
                ResourcesString.STR_TitleWarningNomIntervenant,
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                currentIntervenant.nom = this.txtNom.Text;
                currentIntervenant.actif = (int)this.chbActif.CheckState;
                currentIntervenant.prenom = ""; //temporaire, va etre flushé quand on va réupdater les modeles

                if (editMode == EditMode.Edit)
                {
                    connexionUpdater.Update(currentIntervenant);
                    DialogResult result = MessageBox.Show(ResourcesString.STR_MessageUpdateConfirmation1 + "de l'intervenant" + ResourcesString.STR_MessageUpdateConfirmation2,
                    ResourcesString.STR_TitleUpdateConfirmation,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 
                else if (editMode == EditMode.New)
                {
                    connexionUpdater.Add(currentIntervenant);
                    DialogResult result = MessageBox.Show("L'intervenant " + currentIntervenant.nom + ResourcesString.STR_MessageAddConfirmation,
                    ResourcesString.STR_TitleAddConfirmation,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nouveau();
                }

                loadCbIntervenant();
                
            }
            
        }
    }
}
