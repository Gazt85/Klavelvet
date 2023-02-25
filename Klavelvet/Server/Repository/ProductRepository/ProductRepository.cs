using Klavelvet.Server.Repository.RepositoryBase;
using Microsoft.EntityFrameworkCore;

namespace Klavelvet.Server.Repository.ProductRepository
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(DataContext context) : base(context)
        { }

        public async Task<List<Product>> GetProductsAsync(bool trackChanges) =>
              await FindAll(trackChanges).ToListAsync();



    }
}
