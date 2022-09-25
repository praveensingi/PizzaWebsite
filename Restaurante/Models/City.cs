namespace Restaurante.Models
{
    public class City
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ZipCode { get; set; }

        public string State { get; set; }

        public List<Customer>? Customers { get; set; }

        public List<Order>? Orders { get; set; }

    }
}
