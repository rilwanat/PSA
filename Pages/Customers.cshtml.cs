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
    public class CustomersModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CustomersModel(ApplicationDbContext context)
        {
            _context = context;
        }

        // Define a property to hold the list of customers
        public List<Customer> Customers { get; set; }

        public async Task OnGetAsync()
        {
            // Fetch the list of customers from your database
            Customers = await _context.Customers.ToListAsync();
        }
    }
}
