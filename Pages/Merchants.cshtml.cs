using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PSA.Models;
using PSA.Persistence;

namespace PSA.Pages
{
    public class MerchantsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public MerchantsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        // Define a property to hold the list of merchants
        public List<Merchant> Merchant { get; set; }

        public async Task OnGetAsync()
        {
            // Fetch the list of merchants from your database
            Merchant = await _context.Merchants.ToListAsync();
        }
    }
}
