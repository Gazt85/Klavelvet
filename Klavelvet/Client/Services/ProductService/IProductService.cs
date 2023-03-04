using Klavelvet.Shared.Data_Transfer_Objects.Products;

namespace Klavelvet.Client.Services.ProductService
{
    public interface IProductService
    {
        event Action ProductsChanged;

        List<ProductDto> Products { get; set; }

        Task GetProducts(string? categoryUrl = null);

        Task<ProductDto> GetProduct(Guid id);
    }
}
