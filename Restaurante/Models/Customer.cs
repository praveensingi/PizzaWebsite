using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Restaurante.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [DisplayName("First Name")]
        [Required()]
        [StringLength(100, MinimumLength = 1)]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required()]
        [StringLength(100, MinimumLength = 1)]
        public string LastName { get; set; }

        [DisplayName("Phone Number")]
        [Required()]
        [Phone]
        public string PhoneNumber { get; set; }

        [DisplayName("Email Address")]
        [Required()]
        public string? Email { get; set; }

        [Required()]
        [Range(0, 1000)]
        public int Age { get; set; }

        [DisplayName("Street Address")]
        [Required()]
        public string Address { get; set; }

        public List<Order>? Orders { get; set; }
    }
}
