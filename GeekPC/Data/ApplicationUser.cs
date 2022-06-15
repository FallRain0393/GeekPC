using GeekPC.Models;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace GeekPC.Data
{
    public class ApplicationUser : IdentityUser
    {
        public List<Cart> Carts { get; set; }
    }
}
