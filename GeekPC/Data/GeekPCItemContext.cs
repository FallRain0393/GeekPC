using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GeekPC.Models;

namespace GeekPC.Data
{
    public class GeekPCItemContext : DbContext
    {
        public GeekPCItemContext (DbContextOptions<GeekPCItemContext> options)
            : base(options)
        {
        }

        public DbSet<GeekPC.Models.Item> Item { get; set; }
    }
}
