using GeekPC.Data;
using GeekPC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GeekPC.Pages
{
    public class AddInCartModel : PageModel
    {
        private readonly AppDbContext _context;

        public AddInCartModel(AppDbContext context)
        {
            _context = context;
        }

        public Item Item { get; set; }

        public async Task OnGetAsync(int id)
        {
            Item = await _context.Items.FindAsync(id);

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var cart = new Cart() { UserId = userId, ItemId = Item.ID };
            await _context.Carts.AddAsync(cart);
            await _context.SaveChangesAsync();
        }
    }
}
