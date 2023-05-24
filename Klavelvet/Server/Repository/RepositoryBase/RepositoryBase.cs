using System.Linq.Expressions;

namespace Klavelvet.Server.Repository.RepositoryBase
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected DataContext Datacontext;

        public RepositoryBase(DataContext datacontext)
        {
            Datacontext = datacontext;
        }


        /// <summary>
        /// Finds all entities of the specified type and returns them as an IQueryable object, optionally disabling change tracking.
        /// </summary>
        /// <param name="trackChanges">Whether to track changes to the returned entities.</param>
        /// <returns>An IQueryable object containing all entities of the specified type.</returns>
        /// <remarks>
        /// This method returns all entities of the specified type using the Set method of the Entity Framework DbContext.
        /// If the trackChanges parameter is false, the AsNoTracking method is called on the IQueryable object to disable change tracking.
        /// </remarks>
        public IQueryable<T> FindAll(bool trackChanges) =>
          !trackChanges ?
          Datacontext.Set<T>()
          .AsNoTracking() :
          Datacontext.Set<T>();


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
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expresion, bool trackChanges) =>
          !trackChanges ?
          Datacontext.Set<T>()
          .Where(expresion)
          .AsNoTracking() :
          Datacontext.Set<T>()
          .Where(expresion);


        /// <summary>
        /// Finds and returns a queryable collection of entities of type T based on the given condition expression and a navigation property.
        /// </summary>
        /// <param name="expresion">The expression that defines the condition to be satisfied by the entities.</param>
        /// <param name="navigationPropertyPath">The navigation property path to be included in the query results.</param>
        /// <param name="trackChanges">A boolean value indicating whether or not changes to the entities should be tracked.</param>
        /// <returns>An IQueryable collection of entities of type T.</returns>
        /// <remarks>
        /// This method returns an IQueryable collection of entities of type T based on the given condition expression and a navigation property.
        /// If the 'trackChanges' parameter is set to false, the returned entities will not be tracked, otherwise changes to the entities will be tracked.
        /// </remarks>
        public async Task<IEnumerable<T>> FindByConditionAndNavigation(Expression<Func<T, bool>> expresion,
            Expression<Func<T, object>> navigationPropertyPath,
            bool trackChanges)
        {
            IQueryable<T> query = Datacontext.Set<T>();

            if (trackChanges)
            {
                query = query.AsNoTracking();
            }

            var result = query.Where(expresion)
                              .Include(navigationPropertyPath);

            return await result.ToListAsync();

        }


        /// <summary>
        /// Retrieves a single entity of type <typeparamref name="T"/> from the database, including related entities using the specified navigation property paths.
        /// </summary>
        /// <typeparam name="T">The type of entity to retrieve.</typeparam>
        /// <typeparam name="TProp1">The type of the first related entity to include.</typeparam>
        /// <typeparam name="TProp2">The type of the second related entity to include.</typeparam>
        /// <param name="navigationPropertyPath">An expression representing the first navigation property to include.</param>
        /// <param name="navigationPropertyPath2">An expression representing the second navigation property to include.</param>
        /// <param name="expresion">An expression representing the filter criteria for the entity.</param>
        /// <param name="trackChanges">A boolean indicating whether to track changes for the entity in the database.</param>
        /// <returns>A single entity of type <typeparamref name="T"/>, including related entities specified by the navigation property paths.</returns>
        /// <exception cref="InvalidOperationException">Thrown when the query returns more than one result.</exception>
        public async Task<T> FindWithMultipleNavigationPropertiesAsync<TProp1, TProp2>(
    Expression<Func<T, IEnumerable<TProp1>>> navigationPropertyPath,
    Expression<Func<TProp1, TProp2>> navigationPropertyPath2,
    Expression<Func<T, bool>> expresion,
    bool trackChanges)
        {
            IQueryable<T> query = Datacontext.Set<T>();

            if (trackChanges)
            {
                query = query.AsNoTracking();
            }

            var result = await query.Include(navigationPropertyPath)
                                     .ThenInclude(navigationPropertyPath2)
                                     .SingleOrDefaultAsync(expresion);

            return result;
        }

        /// <summary>
        /// Gets all entities with the specified navigation property eagerly loaded.
        /// </summary>        
        /// <param name="navigationPropertyPath">An expression that specifies the navigation property to eagerly load.</param>
        /// <param name="trackChanges">Whether to track changes to the returned entities.</param>
        /// <remarks>
        /// This method eagerly loads the specified navigation property using the Include method of the Entity Framework DbContext.
        /// </remarks>
        /// <returns>A list of entities with the specified navigation property eagerly loaded.</returns>
        public async Task<IEnumerable<T>> FindAllWithNavigation(Expression<Func<T, object>> navigationPropertyPath, bool trackChanges)
        {
            IQueryable<T> query = Datacontext.Set<T>();

            if (trackChanges)
                query = query.AsNoTracking();

            // Use the navigationPropertyPath to include the navigation property (e.g. Products with Categories)
            query = query.Include(navigationPropertyPath);

            return await query.ToListAsync();
        }


        /// <summary>
        /// Adds a new entity to the context.
        /// </summary>
        /// <param name="entity">The entity to add to the context.</param>
        /// <remarks>
        /// This method adds a new entity to the context using the Add method of the Entity Framework DbContext.
        /// </remarks>
        public void Create(T entity) => Datacontext.Set<T>().Add(entity);


        /// <summary>
        /// Updates an existing entity in the context.
        /// </summary>
        /// <param name="entity">The entity to update in the context.</param>
        /// <remarks>
        /// This method updates an existing entity in the context using the Update method of the Entity Framework DbContext.
        /// </remarks>
        public void Update(T entity) => Datacontext.Set<T>().Update(entity);


        /// <summary>
        /// Deletes an existing entity from the context.
        /// </summary>
        /// <param name="entity">The entity to delete from the context.</param>
        /// <remarks>
        /// This method deletes an existing entity from the context using the Remove method of the Entity Framework DbContext.
        /// </remarks>
        public void Delete(T entity) => Datacontext.Set<T>().Remove(entity);
    }
}
