using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Restaurante.Data;
using Restaurante.Models;

namespace Restaurante.Pages
{
    public class OrderFormModel : PageModel
    {
        private readonly Restaurante.Data.ApplicationDbContext _context;

        public List<FoodItem>? FoodItems { get; set; }

        public OrderFormModel(Restaurante.Data.ApplicationDbContext context)
        {
            _context = context;
            FoodItems = _context.FoodItem.ToList();
        }
        public void OnGet()
        {
        }
    }
}
