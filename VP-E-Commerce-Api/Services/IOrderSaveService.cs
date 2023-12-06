using VP_E_Commerce_Api.dto;

namespace VP_E_Commerce_Api.Services
{
    public interface IOrderSaveService
    {
        int SaveOrder(Order order);
    }
}