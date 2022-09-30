using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Restaurante.Models
{
    public class FoodItem
    {
        public int Id { get; set; }

        [DisplayName("Food Name")]
        [Required()]
        [StringLength(100, MinimumLength = 1)]
        public string Name { get; set; }

        [DisplayName("Food Type")]
        [Required()]
        [StringLength(100, MinimumLength = 1)]
        public string Type { get; set; }

        [Required()]
        [Range(0, (double)decimal.MaxValue)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Required()]
        [StringLength(100, MinimumLength = 1)]
        public string Description { get; set; }

        public List<OrderFoodItem>? OrderFoodItems { get; set; }
    }
}
