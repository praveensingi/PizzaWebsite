namespace Restaurante.Models
{
    public class OrderFoodItem
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        public int OrderId { get; set; }
        public FoodItem FoodItem { get; set; }
        public int FoodItemId { get; set; }

    }
}
