using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Restaurante.Data;
using Restaurante.Models;

namespace Restaurante.Pages.OrderFoodItems
{
    public class EditModel : PageModel
    {
        private readonly Restaurante.Data.ApplicationDbContext _context;

        public EditModel(Restaurante.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public OrderFoodItem OrderFoodItem { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.OrderFoodItem == null)
            {
                return NotFound();
            }

            var orderfooditem =  await _context.OrderFoodItem.FirstOrDefaultAsync(m => m.Id == id);
            if (orderfooditem == null)
            {
                return NotFound();
            }
            OrderFoodItem = orderfooditem;
           ViewData["FoodItemId"] = new SelectList(_context.FoodItem, "Id", "Id");
           ViewData["OrderId"] = new SelectList(_context.Set<Order>(), "Id", "Id");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(OrderFoodItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderFoodItemExists(OrderFoodItem.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool OrderFoodItemExists(int id)
        {
          return _context.OrderFoodItem.Any(e => e.Id == id);
        }
    }
}
