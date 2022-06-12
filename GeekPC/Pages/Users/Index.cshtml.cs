using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GeekPC.Data;
using GeekPC.Models;

namespace GeekPC.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly GeekPC.Data.GeekPCUserContext _context;

        public IndexModel(GeekPC.Data.GeekPCUserContext context)
        {
            _context = context;
        }

        public IList<Contact> Contact { get;set; }

        public async Task OnGetAsync()
        {
            Contact = await _context.Contact.ToListAsync();
        }
    }
}
