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
    public class SearchModel : PageModel
    {
        private readonly Restaurante.Data.ApplicationDbContext _context;

        public bool SearchCompleted { get; set; }

        public string Query { get; set; }

        public SearchModel(Restaurante.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<FoodItem> FoodItem { get;set; } = default!;

        public async Task OnGetAsync(string query)
        {
            Query = query;
            if (!string.IsNullOrEmpty(Query))
            {
                SearchCompleted = true;
                FoodItem = await _context.FoodItem.Where(x => x.Name.Contains(query)).ToListAsync();
            }
            else
            {
                SearchCompleted = false;
                FoodItem = new List<FoodItem>();
            }
        }
    }
}
