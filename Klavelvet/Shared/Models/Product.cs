using System.ComponentModel.DataAnnotations.Schema;

namespace Klavelvet.Shared.Models
{
    public class Product
    {
        public Guid Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string ImageURL { get; set; } = string.Empty;  
        
        public bool Featured { get; set; } = false;

        public Category? Category { get; set; }

        public int CategoryId { get; set; }

        public List<ProductVariant> Variants { get; set; } = new List<ProductVariant>();

    }
}
