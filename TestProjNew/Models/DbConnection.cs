using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using NrcTaskWeb.Models.DbModels;

namespace TestProjNew.Models
{

    public class DbConnection : DbContext
    {
        public DbConnection()
        {
        }

        public DbConnection(DbContextOptions options) : base(options)
        {
        }

        public DbSet<DataSample> Information { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //modelBuilder.Entity<Category>().HasIndex(u => u.Name).IsUnique();
        //    //modelBuilder.Entity<Product>().HasIndex(u => u.Name).IsUnique();
        //    //modelBuilder.Entity<Order>().HasIndex(u => u.SerialNumber).IsUnique();
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=.;database=NewTestDbData;trusted_connection=true;");
            }
        }
    }
}
