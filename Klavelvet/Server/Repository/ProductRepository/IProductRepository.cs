using Klavelvet.Shared.RequestFeatures;

namespace Klavelvet.Server.Repository.ProductRepository
{
    public interface IProductRepository
    {
        Task<PagedList<Product>> GetFeaturedProductsAsync(ProductParameters productParameters,bool trackChanges);
        Task<PagedList<Product>> GetProductsAsync(ProductParameters productParameters, bool trackChanges);

        Task<PagedList<Product>> GetProductsByCategoryAsync(ProductParameters productParameters, string cateogryUrl,bool trackChanges);

        Task<Product> GetProductAsync(Guid id, bool trackChanges);

        Task<PagedList<Product>> SearchProducts(ProductParameters productParameters, string searchText, bool trackChanges);

        Task<List<string>> SearchProductsWithSuggestions(string searchText, bool trackChanges);
    }
}
