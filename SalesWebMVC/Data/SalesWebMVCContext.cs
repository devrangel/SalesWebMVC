using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesWebMVC.Data
{
    public class SalesWebMVCContext : DbContext
    {
        public SalesWebMVCContext (DbContextOptions<SalesWebMVCContext> options)
            : base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Department>(obj => {
        //        obj.HasNoKey();
        //    });
        //}

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
