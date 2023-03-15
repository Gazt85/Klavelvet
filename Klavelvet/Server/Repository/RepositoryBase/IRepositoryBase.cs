using System.Linq.Expressions;

namespace Klavelvet.Server.Repository.RepositoryBase
{
    public interface IRepositoryBase<T>
    {

        /// <inheritdoc cref="RepositoryBase.RepositoryBase{T}.FindAll(bool)" />   
        IQueryable<T> FindAll(bool trackChanges);

        /// <inheritdoc cref="RepositoryBase.RepositoryBase{T}.FindByCondition(Expression{Func{T, bool}}, bool)" />       
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expresion,
            bool trackChanges);

        /// <inheritdoc cref="RepositoryBase.RepositoryBase{T}.FindAllWithNavigation(Expression{Func{T, object}}, bool)" />   
        Task<IEnumerable<T>> FindAllWithNavigation(Expression<Func<T, object>> navigationPropertyPath,
            bool trackChanges);

        /// <inheritdoc cref="RepositoryBase.RepositoryBase{T}.Create(T)" />     
        void Create(T entity);

        /// <inheritdoc cref="RepositoryBase.RepositoryBase{T}.Update(T)" />   
        void Update(T entity);

        /// <inheritdoc cref="RepositoryBase.RepositoryBase{T}.Delete(T)" />   
        void Delete(T entity);

        /// <inheritdoc cref="RepositoryBase.RepositoryBase{T}.FindWithMultipleNavigationPropertiesAsync{TProp1, TProp2}(Expression{Func{T, IEnumerable{TProp1}}}, Expression{Func{TProp1, TProp2}}, Expression{Func{T, bool}}, bool)" /> 
        Task<T> FindWithMultipleNavigationPropertiesAsync<TProp1, TProp2>(Expression<Func<T, IEnumerable<TProp1>>> navigationPropertyPath, Expression<Func<TProp1, TProp2>> navigationPropertyPath2, Expression<Func<T, bool>> expresion, bool trackChanges);
    }
}
