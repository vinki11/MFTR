namespace ProjetMFTR.DataAccess
{
	//Classe ayant la connexion Entity Framework
	class Connexion
	{
		//Membres privés
		//Sera remplacé par un moyen externe de pouvoir l'attribuer
		private static string m_ConnexionString = "Server=.\\Dlafrance;Database=MFTR;user=sa;password=energie1234;";
		private static Entities.MFTREntities m_Instance;

		/// <summary>
		/// Retourne l'instance de la connexion
		/// </summary>
		public static Entities.MFTREntities Instance()
		{
			if (m_Instance is null){
				m_Instance = new Entities.MFTREntities();
				m_Instance.Database.Connection.ConnectionString = m_ConnexionString;
			}
			return m_Instance;
		}
	}
}
