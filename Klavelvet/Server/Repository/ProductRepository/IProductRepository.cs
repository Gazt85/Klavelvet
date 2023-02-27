namespace Klavelvet.Server.Repository.ProductRepository
{
    public interface IProductRepository
    {
        Task<ServiceResponse<List<Product>>> GetProductsAsync(bool trackChanges);

        Task<Product> GetProductAsync(Guid id, bool trackChanges);
    }
}
