using Klavelvet.Shared.Custom_Attributes;
using System.ComponentModel.DataAnnotations;

namespace Klavelvet.Shared.Data_Transfer_Objects.Cart
{
    public class CartItemForCreationDto
    {
        [Required]
        [IsValidGuidNotZero]
        public Guid ProductId { get; set; }

        [Required]
        public int ProductTypeId { get; set; }

        public int Quantity { get; set; }
    }
}
