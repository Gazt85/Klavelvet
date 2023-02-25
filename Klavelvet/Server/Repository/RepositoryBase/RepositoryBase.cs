using System.Linq.Expressions;

namespace Klavelvet.Server.Repository.RepositoryBase
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected  DataContext Datacontext;

        public RepositoryBase(DataContext datacontext)
        {
            Datacontext = datacontext;
        }

        public IQueryable<T> FindAll(bool trackChanges) =>
          !trackChanges ?
          Datacontext.Set<T>()
          .AsNoTracking() :
          Datacontext.Set<T>();

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expresion, bool trackChanges) =>
          !trackChanges ?
          Datacontext.Set<T>()
          .Where(expresion)
          .AsNoTracking() :
          Datacontext.Set<T>()
          .Where(expresion);

        public void Create(T entity) => Datacontext.Set<T>().Add(entity);

        public void Update(T entity) => Datacontext.Set<T>().Update(entity);

        public void Delete(T entity) => Datacontext.Set<T>().Remove(entity);
    }
}
