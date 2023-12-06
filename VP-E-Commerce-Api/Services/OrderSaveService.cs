using VictorianPlumming.ECommerce.Data;
using VictorianPlumming.ECommerce.Domain;
using VP_E_Commerce_Api.dto;

namespace VP_E_Commerce_Api.Services
{
    public class OrderSaveService : IOrderSaveService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IProductRepository _productRepository;

        public OrderSaveService(IOrderRepository orderRepository, IProductRepository productRepository)
        {
            _orderRepository = orderRepository;
            _productRepository = productRepository;
        }

        public int SaveOrder(VP_E_Commerce_Api.dto.Order order)
        {
            if (order == null)
            {
                throw new ArgumentNullException("Order is null.");
            }

            if (order.CustomerName == null)
            {
                throw new ArgumentNullException("CustomerName is null.");
            }

            if (order.OrderItems.Count == 0)
            {
                throw new ArgumentException("OrderItems is empty.");
            }

            var customer = new Customer(order.CustomerName);
            var orderDomain = new VictorianPlumming.ECommerce.Domain.Order(customer);

            foreach (var item in order.OrderItems)
            {
                if (item.ProductId <= 0)
                {
                    throw new ArgumentException("ProductId is invalid.");
                }

                if (item.Quantity <= 0)
                {
                    throw new ArgumentException("Quantity is less than 1.");
                }

                // We could check if the product is in stock.

                var product = _productRepository.FindById(item.ProductId);

                if (product == null)
                {
                    throw new ArgumentNullException("Product does not exist");
                }

                var orderItem = new VictorianPlumming.ECommerce.Domain.OrderItem(product, item.Quantity);
                orderDomain.AddOrderItem(orderItem);
            }

            return _orderRepository.Save(orderDomain); ;
        }
    }
}
