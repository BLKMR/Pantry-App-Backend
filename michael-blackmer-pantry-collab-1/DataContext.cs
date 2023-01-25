using michael_blackmer_pantry_collab_1.Models;
using Microsoft.EntityFrameworkCore;

namespace michael_blackmer_pantry_collab_1
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Family>()
                .HasMany(u => u.Users)
                .WithOne(f => f.Family)
                .HasForeignKey(u => u.FamilyId);

        }

        public DbSet<Family> Families { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }


    }
}