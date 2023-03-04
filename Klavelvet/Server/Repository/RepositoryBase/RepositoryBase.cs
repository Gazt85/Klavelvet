using Klavelvet.Server.Data;
using Microsoft.EntityFrameworkCore;
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


        /// <inheritdoc cref="IRepositoryBase.FindAll(bool)" />    
        public IQueryable<T> FindAll(bool trackChanges) =>
          !trackChanges ?
          Datacontext.Set<T>()
          .AsNoTracking() :
          Datacontext.Set<T>();


        /// <inheritdoc cref="IRepositoryBase.FindByCondition(Expression{Func{T, bool}}, bool)" />       
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expresion, bool trackChanges) =>
          !trackChanges ?
          Datacontext.Set<T>()
          .Where(expresion)
          .AsNoTracking() :
          Datacontext.Set<T>()
          .Where(expresion);


        /// <inheritdoc cref="IRepositoryBase.FindAllWithNavigation(Expression{Func{T, object}}, bool)" />   
        public async Task<IEnumerable<T>> FindAllWithNavigation(Expression<Func<T, object>> navigationPropertyPath, bool trackChanges)
        {
            IQueryable<T> query = Datacontext.Set<T>();

            if (trackChanges)            
                query = query.AsNoTracking();            

            // Use the navigationPropertyPath to include the navigation property (e.g. Products with Categories)
            query = query.Include(navigationPropertyPath);

            return await query.ToListAsync();
        }


        /// <inheritdoc cref="IRepositoryBase.Create(T)" />           
        public void Create(T entity) => Datacontext.Set<T>().Add(entity);


        /// <inheritdoc cref="IRepositoryBase.Update(T)" />   
        public void Update(T entity) => Datacontext.Set<T>().Update(entity);


        /// <inheritdoc cref="IRepositoryBase.Delete(T)" />   
        public void Delete(T entity) => Datacontext.Set<T>().Remove(entity);
    }
}
