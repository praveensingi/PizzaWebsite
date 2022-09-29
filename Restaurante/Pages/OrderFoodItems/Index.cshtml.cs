using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Restaurante.Data;
using Restaurante.Models;

namespace Restaurante.Pages.OrderFoodItems
{
    public class IndexModel : PageModel
    {
        private readonly Restaurante.Data.ApplicationDbContext _context;

        public IndexModel(Restaurante.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<OrderFoodItem> OrderFoodItem { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.OrderFoodItem != null)
            {
                OrderFoodItem = await _context.OrderFoodItem
                .Include(o => o.FoodItem)
                .Include(o => o.Order).ToListAsync();
            }
        }
    }
}
