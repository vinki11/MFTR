using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using ProjetMFTR.DataAccess;

namespace ProjetMFTR.Forms
{
	public partial class ParentPhone : MetroFramework.Forms.MetroForm
	{

		public Entities.Adultes CurrentAdultes;
		public Entities.Telephone CurrentTelephone;

		public ParentPhone(Entities.Adultes adultes)
		{
			InitializeComponent();

			CurrentAdultes = adultes;
		}

		public ParentPhone(Entities.Telephone telephone)
		{
			InitializeComponent();

			txtPhone.Text = telephone.Telephone1;
			txtPoste.Text = telephone.Poste;
			txtPrecision.Text = telephone.Precision;
			txtType.Text = telephone.Type;
			CurrentTelephone = telephone;

		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			//On met à jour
			if (CurrentTelephone != null)
			{
				CurrentTelephone.Telephone1 = txtPhone.Text;
				CurrentTelephone.Poste = txtPoste.Text;
				CurrentTelephone.Precision = txtPrecision.Text;
				CurrentTelephone.Type = txtType.Text;

				Connexion.connexionActionsTelephone.Update(CurrentTelephone);
			}
			else
			{
				CurrentTelephone = new Entities.Telephone();
				CurrentTelephone.Telephone1 = txtPhone.Text;
				CurrentTelephone.Poste = txtPoste.Text;
				CurrentTelephone.Precision = txtPrecision.Text;
				CurrentTelephone.Adulte_ID = CurrentAdultes.Adulte_ID;
				CurrentTelephone.Type = txtType.Text;

				Connexion.connexionActionsTelephone.Add(CurrentTelephone);
			}
		}

	}
}