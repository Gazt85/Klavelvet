namespace Klavelvet.Client.Services.ProductService
{
    public interface IProductService
    {
        Task<ProductDto> GetProduct(Guid id);

        Task GetProducts(string? categoryUrl = null);

        Task <List<string>> GetProductSearchSuggestions(string searchText);

        string Message { get; set; }

        List<ProductDto> Products { get; set; }

        event Action ProductsChanged;

        Task SearchProducts(string searchText);
        

        

        
    }
}
