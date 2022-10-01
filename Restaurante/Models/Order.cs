using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Restaurante.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required()]
        public int Quantity { get; set; }

        [DisplayName("Order Date")]
        [Required()]
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        [DisplayName("Total Cost")]
        [Required()]
        [DataType(DataType.Currency)]
        public decimal TotalCost { get; set; }

        public Customer? Customer { get; set; }

        [DisplayName("Customer Name")]
        public int CustomerId { get; set; }

        public Staff? Staff { get; set; }

        [DisplayName("Staff Name")]
        public int? StaffId { get; set; }

        public List<OrderFoodItem>? OrderFoodItems { get; set; }
    }
}
