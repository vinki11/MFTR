using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetMFTR.Entities.Helper
{
	class ChildWrapper
	{
		public static string GetName(Enfants kid)
		{
			return kid.Prenom + "," + kid.Nom;
		}
	}
}
