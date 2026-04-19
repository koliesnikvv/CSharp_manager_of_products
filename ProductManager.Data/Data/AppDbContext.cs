using Microsoft.EntityFrameworkCore;
using StorageClasses;

namespace ProductManager.Data.Data 
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<DepositaryStorage> Depositories { get; set; }
        public DbSet<ProductsStorage> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=ProductManager.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DepositaryStorage>()
                .HasMany(d => d.Products)
                .WithOne(p => p.Depositary)
                .HasForeignKey(p => p.DepositaryId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<DepositaryStorage>()
                .HasIndex(d => d.Name)
                .IsUnique();

            base.OnModelCreating(modelBuilder);
        }
    }
}