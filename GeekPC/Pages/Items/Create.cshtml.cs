using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GeekPC.Data;
using GeekPC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace GeekPC.Pages.Items
{
    [Authorize(Roles = "Admin")]

    public class CreateModel : PageModel
    {
        private readonly AppDbContext _context;

        public CreateModel(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }
        [BindProperty] public IFormFile[] Uploads { get; set; }
        [BindProperty]
        public Item Item { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Item.Images = new List<Image>();
            foreach (var Upload in Uploads)
            {
                using var fileStream = Upload.OpenReadStream();
                byte[] bytes = new byte[Upload.Length];
                fileStream.Read(bytes, 0, (int)Upload.Length);
                var fileData = Convert.ToBase64String(bytes);
                await fileStream.DisposeAsync();

                Item.Images.Add(new Image() { FileData = fileData });
            }
            _context.Items.Add(Item);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");

        }
    }
}
