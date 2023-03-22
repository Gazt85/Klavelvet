using Klavelvet.Server.Repository.RepositoryBase;
using Klavelvet.Shared.RequestFeatures;

namespace Klavelvet.Server.Repository.ProductRepository
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(DataContext context) : base(context)
        { }

        public async Task<PagedList<Product>> GetProductsAsync(ProductParameters productParameters, bool trackChanges)
        {
            var products = await FindAllWithNavigation(p => p.Variants, trackChanges);

            return PagedList<Product>
                .ToPagedList(products, productParameters.PageNumber, productParameters.PageSize);
        }

        public async Task<PagedList<Product>> GetProductsByCategoryAsync(ProductParameters productParameters, string categoryUrl, bool trackChanges)
        {
            var productsWithCategories = await FindAllWithNavigation(p => p.Category, trackChanges);

            var productsWithVariants = await FindAllWithNavigation(p => p.Variants, trackChanges);

            var productsByCategory = productsWithVariants.Where(p => p.Category.Url.Equals(categoryUrl, StringComparison.OrdinalIgnoreCase));
            return PagedList<Product>
                .ToPagedList(productsByCategory, productParameters.PageNumber, productParameters.PageSize);
        }

        public async Task<Product> GetProductAsync(Guid id, bool trackChanges)
        => await FindWithMultipleNavigationPropertiesAsync(p => p.Variants, v => v.ProductType, p => p.Id == id, trackChanges);

        public async Task<PagedList<Product>> SearchProducts(ProductParameters productParameters, string searchText, bool trackChanges)
        {
            searchText = searchText.Trim().ToLower();

            var products = await FindByConditionAndNavigation(p => p.Title.Contains(searchText),
                p => p.Variants, trackChanges);

            return PagedList<Product>
                .ToPagedList(products, productParameters.PageNumber, productParameters.PageSize);
        }

        public async Task<List<string>> SearchProductsWithSuggestions(string searchText, bool trackChanges)
        {
            searchText = searchText.Trim().ToLower();

            var products = await FindByConditionAndNavigation(p => p.Title.Contains(searchText),
                p => p.Variants, trackChanges);

            var result = new List<string>();

            foreach (var product in products)
            {
                if (product.Title.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(product.Title);
                }
            }

            return result;
        }

        public async Task<PagedList<Product>> GetFeaturedProductsAsync(ProductParameters productParameters, bool trackChanges)
        {
            var products = await FindByConditionAndNavigation(p => p.Featured,
            p => p.Variants, trackChanges);

            return PagedList<Product>
                .ToPagedList(products, productParameters.PageNumber, productParameters.PageSize);
        }
    }
}
