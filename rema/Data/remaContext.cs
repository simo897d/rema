using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using rema.Models;

namespace rema.Data
{
    public class remaContext : DbContext
    {
        public remaContext(DbContextOptions<remaContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }

        public DbSet<Category> Category { get; set; }

        public DbSet<Supplier> Supplier { get; set; }

    }
}
