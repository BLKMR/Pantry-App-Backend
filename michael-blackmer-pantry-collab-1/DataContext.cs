using michael_blackmer_pantry_collab_1.Models;
using Microsoft.EntityFrameworkCore;

namespace michael_blackmer_pantry_collab_1
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<FamilyAccount> FamilyAccounts { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }

    }
}