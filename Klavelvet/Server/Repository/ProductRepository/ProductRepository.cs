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

        public async Task<List<Product>> GetProductsAsync(bool trackChanges)
        {
            var products = await FindAllWithNavigation(p => p.Variants, trackChanges);

            return products.ToList();
        }

        public async Task<List<Product>> GetProductsByCategoryAsync(string categoryUrl, bool trackChanges)
        {
            var productsWithCategories = await FindAllWithNavigation(p => p.Category, trackChanges);

            var productsWithVariants = await FindAllWithNavigation(p => p.Variants, trackChanges);           

            var productsByCategory = productsWithVariants.Where(p => p.Category.Url.Equals(categoryUrl, StringComparison.OrdinalIgnoreCase));

            return productsByCategory.ToList();
        }

        public async Task<Product> GetProductAsync(Guid id, bool trackChanges)
        => await FindWithMultipleNavigationPropertiesAsync(p => p.Variants, v => v.ProductType, p => p.Id == id, trackChanges);      

    }
}
