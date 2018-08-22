using System.Windows.Forms;

namespace ProjetMFTR.DbConnexion.Helper
{
	interface IActions<TEntity>
	{
		//List<TEntity> GetAll();
		//TEntity GetSinglEntity(Func<TEntity, bool> predicate);
		void Print(TEntity entity, PrintDialog t);
		bool Add(TEntity entity);
		bool Update(TEntity entity);
	}
}
