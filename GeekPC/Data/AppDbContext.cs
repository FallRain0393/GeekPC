using GeekPC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GeekPC.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Item> Items { get; set; }

    }
}
