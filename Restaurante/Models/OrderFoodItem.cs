using System.ComponentModel;

namespace Restaurante.Models
{
    public class OrderFoodItem
    {
        public int Id { get; set; }

        public Order? Order { get; set; }

        [DisplayName("Order Id")]
        public int? OrderId { get; set; }

        [DisplayName("Food Item")]
        public FoodItem? FoodItem { get; set; }

        [DisplayName("Food Item Name")]
        public int? FoodItemId { get; set; }
        public int Quantity { get; set; }
    }
}
