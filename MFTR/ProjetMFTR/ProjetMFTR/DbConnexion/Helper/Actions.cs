using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetMFTR.DbConnexion.Helper
{
	 interface IActions<TEntity>
	{
			//List<TEntity> GetAll();
			//TEntity GetSinglEntity(Func<TEntity, bool> predicate);
			//bool Delete(TEntity entity);
			bool Add(TEntity entity);
			bool Update(TEntity entity);
	}
}
