namespace VictorianPlumming.ECommerce.Domain
{
    public class Customer
    {
        public Customer(string name)
        {
            CustomerId = 0;
            Name = name;
        }

        public Customer(int customerId, string name)
        {
            CustomerId = customerId;
            Name = name;
        }

        public int CustomerId { get; }
        public string Name { get; set; }
    }
}