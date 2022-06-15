using GeekPC.Data;
using GeekPC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace GeekPC.Pages
{
    public class DeleteInCartModel : PageModel
    {
        private readonly AppDbContext _context;

        public DeleteInCartModel(AppDbContext context)
        {
            _context = context;
        }

        public Cart Cart { get; set; }
        public async Task OnGetAsync(int id)
        {
            Cart = await _context.Carts.Include(t => t.Item).FirstAsync(t => t.Id == id);

            _context.Carts.Remove(Cart);
            await _context.SaveChangesAsync();
        }
    }
}
