using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Restaurante.Models;

namespace Restaurante.Pages
{
    public class StatisticsModel : PageModel
    {
        private readonly Restaurante.Data.ApplicationDbContext _context;

        public int TotalCustomers { get; set; }

        public int TotalTodayOrders { get; set; }

        public int TotalFoodItems { get; set; }

        public int TotalDrinks { get; set; }
        public int TotalOrders { get; set; }

        public decimal TotalRevenue { get; set; }
        public StatisticsModel(Restaurante.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            TotalCustomers = await _context.Customer.CountAsync();
            TotalOrders = await _context.Order.CountAsync();
            TotalTodayOrders = await _context.Order.CountAsync(x => x.OrderDate == DateTime.Today);

            var orders = _context.Order
                .Include(o => o.OrderFoodItems)
                .ThenInclude(oi => oi.FoodItem);
            
            foreach(var order in orders){
                foreach(var orderedfooditem in order.OrderFoodItems)
                {
                    var item = await _context.FoodItem.FirstOrDefaultAsync(m => m.Id == orderedfooditem.FoodItemId);
                    if(item.Type == "drink")
                    {
                        TotalDrinks += orderedfooditem.Quantity;
                    }
                    else
                    {
                        TotalFoodItems += orderedfooditem.Quantity;
                    }

                    TotalRevenue +=  orderedfooditem.Quantity * item.Price;
                }
            }
            
        }
    }
}
