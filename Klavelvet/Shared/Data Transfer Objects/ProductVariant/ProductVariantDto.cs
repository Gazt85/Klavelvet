using Klavelvet.Shared.Data_Transfer_Objects.ProductType;
using System.ComponentModel.DataAnnotations.Schema;

namespace Klavelvet.Shared.Data_Transfer_Objects.ProductVariant
{
    public class ProductVariantDto
    {
        public Guid ProductId { get; set; }

        public int ProductTypeId { get; set; }

        public ProductTypeDto? ProductType { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal OriginalPrice { get; set; }
    }
}
