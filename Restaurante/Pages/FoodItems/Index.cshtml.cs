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
    public class IndexModel : PageModel
    {
        private readonly Restaurante.Data.ApplicationDbContext _context;

        public IndexModel(Restaurante.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<FoodItem> FoodItem { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.FoodItem != null)
            {
                FoodItem = await _context.FoodItem.ToListAsync();
            }
        }
    }
}
