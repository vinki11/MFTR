using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetMFTR.DataAccess;
using ProjetMFTR.Resources;

namespace ProjetMFTR.Windows.Payments
{
	public partial class Payment : MetroFramework.Forms.MetroForm
	{
		public Payment()
		{
			InitializeComponent();
			InitializeFolders();
		}

		private void InitializeFolders()
		{
			cboFolders.DataSource = Connexion.Instance().Dossier.OrderByDescending((x) => x.Ouverture).ToList();
			cboFolders.DisplayMember = ResourcesString.STR_Dossier_ID;
			cboFolders.ValueMember = ResourcesString.STR_Dossier_ID;
			cboFolders.SelectedValue = -1;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnPayment_Click(object sender, EventArgs e)
		{
			//Do payment
		}
	}
}
