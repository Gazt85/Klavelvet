using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Klavelvet.Shared.Models
{
    public class ProductVariant
    {
        [JsonIgnore]
        public Product? Product { get; set; }

        public Guid ProductId { get; set; }

        public ProductType? ProductType { get; set; }

        public int ProductTypeId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal OriginalPrice { get; set; }
    }
}
