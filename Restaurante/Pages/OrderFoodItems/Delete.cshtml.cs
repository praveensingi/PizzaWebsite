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
    public class DeleteModel : PageModel
    {
        private readonly Restaurante.Data.ApplicationDbContext _context;

        public DeleteModel(Restaurante.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.OrderFoodItem == null)
            {
                return NotFound();
            }
            var orderfooditem = await _context.OrderFoodItem.FindAsync(id);

            if (orderfooditem != null)
            {
                OrderFoodItem = orderfooditem;
                _context.OrderFoodItem.Remove(OrderFoodItem);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
