namespace VictorianPlumming.ECommerce.Domain
{
    public class Product
    {
        public Product(string name, int price)
        {
            ProductId = 0;
            Name = name;
            Price = price;
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; } // Does this need to be a currency type?
    }
}