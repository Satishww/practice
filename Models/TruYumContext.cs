using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TruYumCaseStudyMVC.Models
{
    public class TruYumContext : DbContext
    {

        public TruYumContext()
        {
        }

        public TruYumContext(DbContextOptions<TruYumContext> options)
            : base(options)
        {
        }

        public DbSet<MenuItem> MenuItems { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Cart> Carts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MenuItem>().ToTable("MenuItem");
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Cart>().ToTable("Cart");
        }
    }
}
