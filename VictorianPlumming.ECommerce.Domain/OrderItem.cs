namespace VictorianPlumming.ECommerce.Domain
{
    public class OrderItem
    {
        public OrderItem(Product product, int quantity)
        {
            OrderItemId = 0;
            Product = product;
            Quantity = quantity;
            Price = product.Price;
        }

        public OrderItem(int orderItemId, Product product, int quantity, decimal price)
        {
            OrderItemId = orderItemId;
            Product = product;
            Quantity = quantity;
            Price = price;
        }

        public int OrderItemId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal LineTotal => Price * Quantity;
    }
}