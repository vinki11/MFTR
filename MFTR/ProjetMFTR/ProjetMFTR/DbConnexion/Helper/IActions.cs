using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetMFTR.DbConnexion.Helper
{
	interface IActions<TEntity>
	{
		//List<TEntity> GetAll();
		//TEntity GetSinglEntity(Func<TEntity, bool> predicate);
		void Print(TEntity entity, PrintDialog t);
		bool Add(TEntity entity);
		//async Task<List<TEntity>> GetAllAsync();
		bool Update(TEntity entity);
		void UpdateFolderIDs(string oldId, string newID);
	}
}
