using Klavelvet.Server.Repository.RepositoryBase;
using Klavelvet.Shared.Models;
using Microsoft.AspNetCore.Http.HttpResults;
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


        public async Task<ServiceResponse<List<Product>>> GetProductsAsync(bool trackChanges)
        {
            var products = await FindAll(trackChanges).ToListAsync();

            var response = new ServiceResponse<List<Product>>()
            {
                Data = products
            };

            return response;
        }              
    }
}
