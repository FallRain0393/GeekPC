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
using Microsoft.AspNetCore.Authorization;

namespace GeekPC.Pages.Items
{
    [Authorize(Roles = "Admin")]

    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public IList<Item> Item { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Category { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ItemName { get; set; }

        public async Task OnGetAsync()
        {
            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in _context.Items
                                            orderby m.Category
                                            select m.Category;

            var items = from m in _context.Items
                         select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                items = items.Where(s => s.Name.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(ItemName))
            {
                items = items.Where(x => x.Category == ItemName);
            }
            Category = new SelectList(await genreQuery.Distinct().ToListAsync());
            Item = await items.ToListAsync();
        }
    }
}
