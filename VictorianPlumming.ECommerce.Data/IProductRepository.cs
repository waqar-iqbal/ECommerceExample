using VictorianPlumming.ECommerce.Domain;

namespace VictorianPlumming.ECommerce.Data
{
    public interface IProductRepository
    {
        Product FindById(int id);

        int Save(Product order);
    }
}