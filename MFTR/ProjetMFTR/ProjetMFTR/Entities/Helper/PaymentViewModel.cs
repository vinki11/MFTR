using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetMFTR.Entities.Helper
{
	class PaymentViewModel
	{

		public string ChildName { get; set; }
		public DateTime DatePayment { get; set; }
		public double Amount { get; set; }
		public string Intervenant { get; set; }
		public string Service { get; set; }
		public string Carrier { get; set; }


		public void Build(Payments payment)
		{
			this.ChildName = payment.Enfants.Nom + "," + payment.Enfants.Prenom;
			this.DatePayment = payment.DatePayment;
			this.Amount = (double)payment.Amount;
			this.Service = payment.Service;
			this.Carrier = payment.Carrier;
			this.Intervenant = payment.Intervenant.nom;
		}
	}
}
