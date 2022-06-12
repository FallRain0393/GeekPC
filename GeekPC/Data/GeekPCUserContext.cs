using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GeekPC.Models;

namespace GeekPC.Data
{
    public class GeekPCUserContext : DbContext
    {
        public GeekPCUserContext (DbContextOptions<GeekPCUserContext> options)
            : base(options)
        {
        }

        public DbSet<GeekPC.Models.Contact> Contact { get; set; }
    }
}
