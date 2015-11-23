using Portfolio.Domain.Models;
using System.Data.Entity;

namespace Portfolio.DAL
{
    public class PortfolioDbContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        DbSet<Post> Posts { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Tag> Tags { get; set; }
    }
}
