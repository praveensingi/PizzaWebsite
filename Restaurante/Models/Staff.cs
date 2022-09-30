using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Restaurante.Models
{
    public class Staff
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

        [DisplayName("Role/Job-Title")]
        [Required()]
        [StringLength(100, MinimumLength = 1)]
        public string Role { get; set; }

        [Required()]
        [Range(0, (double)decimal.MaxValue)]
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }

        [DisplayName("Street Address")]
        [Required()]
        public string Address { get; set; }

        [DisplayName("Phone Number")]
        [Required()]
        [Phone]
        public string PhoneNumber { get; set; }

        [DisplayName("Social Security Number")]
        [Required()]
        [StringLength(11, MinimumLength = 1)]
        public string Ssn { get; set; }

        [DisplayName("Email Address")]
        [Required()]
        public string Email { get; set; }

        public List<Order>? Orders { get; set; }
    }
}
