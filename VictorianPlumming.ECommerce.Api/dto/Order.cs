namespace VictorianPlumming.ECommerce.Api.dto
{
    public class Order
    {
        public string CustomerName { get; set; }

        public List<OrderItem> OrderItems { get; set; }
    }
}