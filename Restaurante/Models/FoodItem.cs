namespace Restaurante.Models
{
    public class FoodItem
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public List<Order>? Orders { get; set; }

    }
}
