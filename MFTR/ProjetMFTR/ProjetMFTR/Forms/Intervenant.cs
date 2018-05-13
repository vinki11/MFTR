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
        public Intervenant()
        {
            InitializeComponent();
            loadIntervenant();
        }
        
        private void cboFolders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Intervenant_Load(object sender, EventArgs e)
        {

        }

        private void loadIntervenant()
        {
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
    }
}
