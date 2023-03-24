using Klavelvet.Client.Features;
using Klavelvet.Shared.RequestFeatures;

namespace Klavelvet.Client.Services.ProductService
{
    public interface IProductService
    {
        Task<ProductDto> GetProduct(Guid id);

        Task<PagingResponse<ProductDto>> GetProducts(ProductParameters productsParameters, string? categoryUrl = null);

        Task <List<string>> GetProductSearchSuggestions(string searchText);

        string Message { get; set; }

        PagingResponse<ProductDto> ProductResponse { get; set; }

        event Action ProductsChanged;

        Task<PagingResponse<ProductDto>> SearchProducts(ProductParameters productsParameters,string searchText);
        

        

        
    }
}
