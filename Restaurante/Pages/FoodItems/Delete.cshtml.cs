using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Restaurante.Data;
using Restaurante.Models;

namespace Restaurante.Pages.FoodItems
{
    public class DeleteModel : PageModel
    {
        private readonly Restaurante.Data.ApplicationDbContext _context;

        public DeleteModel(Restaurante.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public FoodItem FoodItem { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.FoodItem == null)
            {
                return NotFound();
            }

            var fooditem = await _context.FoodItem.FirstOrDefaultAsync(m => m.Id == id);

            if (fooditem == null)
            {
                return NotFound();
            }
            else 
            {
                FoodItem = fooditem;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.FoodItem == null)
            {
                return NotFound();
            }
            var fooditem = await _context.FoodItem.FindAsync(id);

            if (fooditem != null)
            {
                FoodItem = fooditem;
                _context.FoodItem.Remove(FoodItem);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
