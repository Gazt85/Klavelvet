namespace Klavelvet.Server.Repository.ProductRepository
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProductsAsync(bool trackChanges);
    }
}
