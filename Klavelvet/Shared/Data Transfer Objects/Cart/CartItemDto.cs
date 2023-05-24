namespace Klavelvet.Shared.Data_Transfer_Objects.Cart
{
    public class CartItemDto
    {
        public string ImageUrl { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public Guid ProductId { get; set; }

        public string ProductType { get; set; } = string.Empty;

        public int ProductTypeId { get; set; }

        public string Title { get; set; } = string.Empty;

        public int Quantity { get; set; } = 1;
    }
}
