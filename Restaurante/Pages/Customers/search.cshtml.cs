using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Restaurante.Data;
using Restaurante.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Restaurante.Pages.Customers
{
    public class searchModel : PageModel
    {
        private readonly Restaurante.Data.ApplicationDbContext _context;

        public bool SearchCompleted { get; set; }
        public string Query { get; set; }

        public searchModel(Restaurante.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; } = default!;

        public async Task OnGetAsync(string query)
        {
            Query = query;
            if (!string.IsNullOrEmpty(Query))
            {
                SearchCompleted = true;
                Customer = await _context.Customer.Where(x => x.FirstName.Contains(query) || x.LastName.Contains(query)).ToListAsync();
            }
            else
            {
                SearchCompleted = false;
                Customer = new List<Customer>();
            }
        }
    }
}
