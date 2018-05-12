using System;
using ProjetMFTR.DbConnexion.Helper;

namespace ProjetMFTR.DataAccess
{
	//Classe ayant la connexion Entity Framework
	class Connexion
	{
		//Membres privés
		//Sera remplacé par un moyen externe de pouvoir l'attribuer
		private static string m_ConnexionString = "Server=.\\Dlafrance;Database=MFTR;user=sa;password=energie1234;";
    //private static string m_ConnexionString = "Server=.\\PC-VINCENT;Database=MFTR;user=sa;password=soleil123;";
    private static Entities.MFTR m_Instance;

		//Voir si on garde en singleton ou non (ne permet pas de refresh les instances et d'avoir du data à jour
		/// <summary>
		/// Retourne l'instance de la connexion
		/// </summary>
		public static Entities.MFTR Instance()
		{
			if (m_Instance is null){
				m_Instance = new Entities.MFTR();
				m_Instance.Database.Connection.ConnectionString = m_ConnexionString;
			}
				return m_Instance;
		}

		/// <summary>
		/// Classe partial pour update
		/// </summary>
		public partial class ConnexionUpdater<TEntity> : IActions<TEntity>  where TEntity : class
		{
			public bool Add(TEntity entity)
			{
				try
				{
						m_Instance.Entry(entity).State = System.Data.Entity.EntityState.Modified;
						m_Instance.Set<TEntity>().Add(entity);
						m_Instance.SaveChanges();
						return true;
				}
				catch (Exception e)
				{
					return false;
				}
			}

			public bool Update(TEntity entity)
		{
			try
			{
					m_Instance.Entry(entity).State = System.Data.Entity.EntityState.Modified;
					m_Instance.Entry(entity).OriginalValues.SetValues(entity);
					m_Instance.SaveChanges();
					return true;
			}
			catch (Exception e)
			{ 
					return false;
			}
		}

		}
	}
}
