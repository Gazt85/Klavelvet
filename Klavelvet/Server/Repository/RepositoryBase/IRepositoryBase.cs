using System.Linq.Expressions;

namespace Klavelvet.Server.Repository.RepositoryBase
{
    public interface IRepositoryBase<T>
    {

        /// <summary>
        /// Finds all entities of the specified type and returns them as an IQueryable object, optionally disabling change tracking.
        /// </summary>
        /// <param name="trackChanges">Whether to track changes to the returned entities.</param>
        /// <returns>An IQueryable object containing all entities of the specified type.</returns>
        /// <remarks>
        /// This method returns all entities of the specified type using the Set method of the Entity Framework DbContext.
        /// If the trackChanges parameter is false, the AsNoTracking method is called on the IQueryable object to disable change tracking.
        /// </remarks>
        IQueryable<T> FindAll(bool trackChanges);

        /// <summary>
        /// Finds entities of the specified type that match the specified expression and returns them as an IQueryable object, optionally disabling change tracking.
        /// </summary>
        /// <param name="expresion">An expression that specifies the condition that entities must match.</param>
        /// <param name="trackChanges">Whether to track changes to the returned entities.</param>
        /// <returns>An IQueryable object containing entities of the specified type that match the specified condition.</returns>
        /// <remarks>
        /// This method returns entities of the specified type that match the specified expression using the Where method of the Entity Framework DbContext.
        /// If the trackChanges parameter is false, the AsNoTracking method is called on the IQueryable object to disable change tracking.
        /// </remarks>
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expresion,
            bool trackChanges);

        /// <summary>
        /// Gets all entities with the specified navigation property eagerly loaded.
        /// </summary>        
        /// <param name="navigationPropertyPath">An expression that specifies the navigation property to eagerly load.</param>
        /// <param name="trackChanges">Whether to track changes to the returned entities.</param>
        /// <remarks>
        /// This method eagerly loads the specified navigation property using the Include method of the Entity Framework DbContext.
        /// </remarks>
        /// <returns>A list of entities with the specified navigation property eagerly loaded.</returns>
        Task<IEnumerable<T>> FindAllWithNavigation(Expression<Func<T, object>> navigationPropertyPath,
            bool trackChanges);

        /// <summary>
        /// Adds a new entity to the context.
        /// </summary>
        /// <param name="entity">The entity to add to the context.</param>
        /// <remarks>
        /// This method adds a new entity to the context using the Add method of the Entity Framework DbContext.
        /// </remarks>
        void Create(T entity);

        /// <summary>
        /// Updates an existing entity in the context.
        /// </summary>
        /// <param name="entity">The entity to update in the context.</param>
        /// <remarks>
        /// This method updates an existing entity in the context using the Update method of the Entity Framework DbContext.
        /// </remarks>
        void Update(T entity);

        /// <summary>
        /// Deletes an existing entity from the context.
        /// </summary>
        /// <param name="entity">The entity to delete from the context.</param>
        /// <remarks>
        /// This method deletes an existing entity from the context using the Remove method of the Entity Framework DbContext.
        /// </remarks>
        void Delete(T entity);
    }
}
