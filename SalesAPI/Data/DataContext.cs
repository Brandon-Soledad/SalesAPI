using SalesAPI.Data.Models;

    
namespace SalesAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<SalesItem> SalesItems { get; set; }
        public DbSet<ImageItem> Images { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SalesItem>()
                .HasMany(s => s.Images)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
