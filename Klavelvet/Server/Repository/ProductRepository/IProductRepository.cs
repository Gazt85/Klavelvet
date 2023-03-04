namespace Klavelvet.Server.Repository.ProductRepository
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProductsAsync(bool trackChanges);

        Task<List<Product>> GetProductsByCategoryAsync(string cateogryUrl,bool trackChanges);

        Task<Product> GetProductAsync(Guid id, bool trackChanges);
    }
}
