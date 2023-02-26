using Klavelvet.Server.Repository.RepositoryBase;
using Klavelvet.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Klavelvet.Server.Repository.ProductRepository
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(DataContext context) : base(context)
        { }

        public async Task<Product> GetProductAsync(Guid id, bool trackChanges) =>
              await FindByCondition(p => p.Id.Equals(id), trackChanges)
            .SingleOrDefaultAsync();


        public async Task<List<Product>> GetProductsAsync(bool trackChanges) =>
              await FindAll(trackChanges).ToListAsync();



    }
}
