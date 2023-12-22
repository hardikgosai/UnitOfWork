using Getri_UnitOfWork.Models;
using Microsoft.EntityFrameworkCore;

namespace Getri_UnitOfWork.EntityFramework
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new UserMap(modelBuilder.Entity<User>());
            new ProductMap(modelBuilder.Entity<Product>());
        }
    }    
}
