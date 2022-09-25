namespace Restaurante.Models
{
    public class Order
    {

        public int Id { get; set; }

        public int Quantity { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal TotalCost { get; set; }

        public Customer Customer { get; set; }

        public int CustomerId { get; set; }

        public City City { get; set; }

        public int CityId { get; set; }

        public Staff Staff { get; set; }

        public int StaffId { get; set; }

        public List<FoodItem> FoodItems { get; set; }


    }
}
