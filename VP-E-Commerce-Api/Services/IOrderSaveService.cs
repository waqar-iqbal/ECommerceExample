using VictorianPlumming.ECommerce.Api.dto;

namespace VictorianPlumming.ECommerce.Api.Services
{
    public interface IOrderSaveService
    {
        int SaveOrder(Order order);
    }
}