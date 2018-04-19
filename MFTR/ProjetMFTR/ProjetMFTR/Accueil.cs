using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetMFTR
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }
#region Events
        private void btnAdd_Click(object sender, EventArgs e)
        {
           Suivi suivi = new Suivi();
           suivi.Show();
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnGestion_Click(object sender, EventArgs e)
        {

        }
#endregion

    }
}
