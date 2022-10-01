using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Restaurante.Data;
using Restaurante.Models;

namespace Restaurante.Pages.OrderFoodItems
{
    public class CreateModel : PageModel
    {
        private readonly Restaurante.Data.ApplicationDbContext _context;

        public CreateModel(Restaurante.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["FoodItemId"] = new SelectList(_context.FoodItem, "Id", "Name");
        ViewData["OrderId"] = new SelectList(_context.Set<Order>(), "Id", "Id");
            return Page();
        }

        [BindProperty]
        public OrderFoodItem OrderFoodItem { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.OrderFoodItem.Add(OrderFoodItem);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
