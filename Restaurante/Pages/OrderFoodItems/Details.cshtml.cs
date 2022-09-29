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
    public class DetailsModel : PageModel
    {
        private readonly Restaurante.Data.ApplicationDbContext _context;

        public DetailsModel(Restaurante.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public OrderFoodItem OrderFoodItem { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.OrderFoodItem == null)
            {
                return NotFound();
            }

            var orderfooditem = await _context.OrderFoodItem.FirstOrDefaultAsync(m => m.Id == id);
            if (orderfooditem == null)
            {
                return NotFound();
            }
            else 
            {
                OrderFoodItem = orderfooditem;
            }
            return Page();
        }
    }
}
