using Klavelvet.Shared.Data_Transfer_Objects.Products;

namespace Klavelvet.Client.Services.ProductService
{
    public interface IProductService
    {
        List<ProductDto> Products { get; set; }

        Task GetProducts();

        Task<ProductDto> GetProduct(Guid id);
    }
}
