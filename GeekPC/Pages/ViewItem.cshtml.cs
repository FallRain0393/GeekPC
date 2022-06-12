using GeekPC.Data;
using GeekPC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace GeekPC.Pages
{
    public class ViewItemModel : PageModel
    {
        private readonly AppDbContext _context;

        public ViewItemModel(AppDbContext context)
        {
            _context = context;
        }

        public Item Item { get; set; }

        public async Task OnGetAsync(int id)
        {
            Item = await _context.Items.Include(t => t.Images).FirstAsync(t => t.ID == id);
        }
    }
}
