using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetMFTR.DataAccess
{
	class KidsDataAccess
	{
		// DataTable
		private DataTable dataTable = new DataTable();
		public List<Kids> kids = new List<Kids>();

		public List<Kids> GetKids()
		{
			SqlConnection conn = new ConnexionDataAccess().Instance();

			string query = "Select Enfant_ID, Nom, Prenom from Enfants";
			SqlCommand cmd = new SqlCommand(query, conn);
			conn.Open();

			// DataAdapter
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			// Ajouter la requête
			da.Fill(dataTable);
			conn.Close();
			da.Dispose();

			kids.Clear();

			foreach (DataRow row in dataTable.Rows)
			{
				kids.Add(new Kids() { id = (int)row["Enfant_ID"], name = row["Nom"].ToString(), prenom = row["Prenom"].ToString()});
			}

			return kids;
		}
	}

	//Classe partielle pour les enfants.
	public partial class Kids
	{
		public Kids(){}

		public int id { get; set; }
		public string name { get; set; }
		public string prenom { get; set; }
		public string concatened { get { return prenom + "," + name; }  }
	}
}
