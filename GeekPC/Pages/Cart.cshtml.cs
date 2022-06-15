using GeekPC.Data;
using GeekPC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GeekPC.Pages
{
    public class CartModel : PageModel
    {
        private readonly AppDbContext _context;

        public CartModel(AppDbContext context)
        {
            _context = context;
        }
        public List<Cart> Carts { get; set; }
        public async Task OnGetAsync()
        {
            Carts = await _context.Carts.Include(t => t.Item)
                .Where(t => t.UserId == User.FindFirstValue(ClaimTypes.NameIdentifier)) 
                .ToListAsync();
        }
    }
}
