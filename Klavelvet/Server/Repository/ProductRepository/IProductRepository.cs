namespace Klavelvet.Server.Repository.ProductRepository
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProductsAsync(bool trackChanges);

        Task<List<Product>> GetProductsByCategoryAsync(string cateogryUrl,bool trackChanges);

        Task<Product> GetProductAsync(Guid id, bool trackChanges);

        Task<List<Product>> SearchProducts(string searchText, bool trackChanges);

        Task<List<string>> SearchProductsWithSuggestions(string searchText, bool trackChanges);
    }
}
