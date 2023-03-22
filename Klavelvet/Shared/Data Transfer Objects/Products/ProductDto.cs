using Klavelvet.Shared.Data_Transfer_Objects.ProductVariant;

namespace Klavelvet.Shared.Data_Transfer_Objects.Products
{
    public class ProductDto
    {

        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string ImageURL { get; set; } = string.Empty;

        public bool Featured { get; set; } = false;

        public int CategoryId { get; set; }

        public List<ProductVariantDto>? Variants { get; set; } = new();
    }
}
