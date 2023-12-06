using VictorianPlumming.ECommerce.Domain;

namespace VictorianPlumming.ECommerce.Data
{
    public interface IOrderRepository
    {
        Order FindOrder(int id);

        int Save(Order order);
    }
}