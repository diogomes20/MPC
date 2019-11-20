namespace Mpc.WinFormsIoC.Data.Ef
{
    using Microsoft.EntityFrameworkCore;
    using Mpc.WinFormsIoC.Data.Ef.Mappings;
    using Mpc.WinFormsIoC.Domain.Models;

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
            ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<CountryModel> Countries { get; set; }

        public DbSet<UserModel> Users { get; set; }

        public DbSet<ReviewModel> Reviews { get; set; }

        public DbSet<PlaceModel> Places { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMapping());
            modelBuilder.ApplyConfiguration(new CountryMapping());
            modelBuilder.ApplyConfiguration(new PlaceMapping());
            modelBuilder.ApplyConfiguration(new ReviewMapping());
        }
    }
}
