namespace Restaurante.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string? Email { get; set; }

        public int Age { get; set; }

        public string Address { get; set; }

        public City? City { get; set; }

        public int CityId { get; set; }

        public List<Order> Orders { get; set; }



    }
}
