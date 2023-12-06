namespace VictorianPlumming.ECommerce.Domain
{
    public class Order
    {
        public Order(Customer customer)
        {
            OrderId = 0;
            Customer = customer;
            OrderItems = new List<OrderItem>();
        }

        public Order(int orderId, Customer customer)
        {
            OrderId = orderId;
            Customer = customer;
            OrderItems = new List<OrderItem>();
        }

        public int OrderId { get; }
        public Customer Customer { get; }
        private List<OrderItem> OrderItems { get; set; }
        public decimal OrderTotal => OrderItems.Sum(x => x.LineTotal);

        public void AddOrderItem(OrderItem orderItem)
        {
            if (orderItem == null)
            {
                throw new ArgumentNullException(nameof(orderItem));
            }

            if (OrderItems.Contains(orderItem))
            {
                throw new ArgumentException("Can not add item to the list - item already exists in the order.");
            }

            OrderItems.Add(orderItem);
        }

        public void RemoveOrderItem(OrderItem orderItem)
        {
            if (orderItem == null)
            {
                throw new ArgumentNullException(nameof(orderItem));
            }

            if (!OrderItems.Contains(orderItem))
            {
                throw new ArgumentException("Item not found in the list.");
            }

            OrderItems.Remove(orderItem);
        }
    }
}