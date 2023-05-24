namespace Klavelvet.Shared.Data_Transfer_Objects.Cart
{
    public class CartItemForCreationDto
    {
        public Guid ProductId { get; set; }

        public int ProductTypeId { get; set; }

        public int Quantity { get; set; }
    }
}
