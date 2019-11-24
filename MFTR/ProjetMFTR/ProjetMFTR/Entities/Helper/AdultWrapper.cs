using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetMFTR.Entities.Helper
{
	class AdultWrapper
	{
		public static string GetFullName(Adultes adultes)
		{
			return adultes.Prenom + "," + adultes.Nom;
		}
	}
}
