namespace Restaurante.Models
{
    public class Staff
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }    

        public string Role { get; set; }

        public decimal Salary { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string Ssn { get; set; }

        public string Email { get; set; }

        public List<Order>? Orders { get; set; }
    }
}
