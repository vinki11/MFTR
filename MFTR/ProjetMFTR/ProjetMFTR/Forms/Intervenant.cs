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
                this.txtNom.ReadOnly = false;
                this.txtNom.Text = currentIntervenant.nom;
            }
           else
            {
                this.txtNom.Text = "";
                this.txtNom.ReadOnly = true;
            }
        }

        private void loadCbIntervenant()
        {
            currentIntervenant = null;
            this.txtNom.Text = "";
            this.txtNom.ReadOnly = true;
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

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            currentIntervenant.nom = this.txtNom.Text;

            if (editMode == EditMode.Edit)
            {
                connexionUpdater.Update(currentIntervenant);
            }
        }
    }
}
