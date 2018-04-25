using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetMFTR.DataAccess
{
	class ConnexionDataAccess
	{
		//Membres privés
		string m_ConnexionString = "Server=DESKTOP-Q892IKH\\SQL;Database=MFTR_PROTOTYPE;user=sa;password=energie1234;";
		SqlConnection m_SqlConnexion;

		/// <summary>
		/// Retourne l'instance de la connexion
		/// </summary>
		public SqlConnection Instance()
		{
			if (m_SqlConnexion is null){
				m_SqlConnexion = new SqlConnection(m_ConnexionString);
			}
			return m_SqlConnexion;
		}
	}
}
