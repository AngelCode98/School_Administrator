using Microsoft.EntityFrameworkCore;
using School_Administrator.Data.Entities;

namespace School_Administrator.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Institution> institutions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Institution>().HasIndex(i => i.Name).IsUnique();
        }
    }
}
