using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Restaurante.Data;
using Restaurante.Models;

namespace Restaurante.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly Restaurante.Data.ApplicationDbContext _context;

        public IndexModel(Restaurante.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Order != null)
            {
                Order = await _context.Order
                .Include(o => o.City)
                .Include(o => o.Customer)
                .Include(o => o.Staff).ToListAsync();
            }
        }
    }
}
