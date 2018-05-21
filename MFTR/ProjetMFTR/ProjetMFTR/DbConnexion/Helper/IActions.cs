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
