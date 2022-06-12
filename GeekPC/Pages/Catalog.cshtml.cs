using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GeekPC.Data;
using GeekPC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GeekPC.Pages
{
    public class CatalogModel : PageModel
    {
        private readonly AppDbContext _context;

        public CatalogModel(AppDbContext context)
        {
            _context = context;
        }

        public IList<Item> Item { get;set; }
        public string SearchString { get; set; }
        public SelectList Category { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ItemName { get; set; }

        public async Task OnGetAsync()
        {
            
            
            Item = await _context.Items.Include(t => t.Images).ToListAsync();
           

        }
    }
}
