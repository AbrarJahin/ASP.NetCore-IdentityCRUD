using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using IdentityCrud.Models;

namespace IdentityCrud.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        //Table List
        public DbSet<ProductCategory> ProductCategorys { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Entry> Entries { get; set; }
        public DbSet<Exit> Exits { get; set; }
        /*public DbSet<User> Uses { get; set; }
        public DbSet<Role> Roles { get; set; }*/
        //Table List End

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            //many to many relation configuration
            /*
                modelBuilder.Entity<Country>(e =>
                {
                    e.HasAlternateKey(c => new { c.BengaliName });
                    e.HasAlternateKey(c => new { c.EnglishName });
                    e.HasAlternateKey(c => new { c.ShortName });
                });

                modelBuilder.Entity<CountryPerson>(cp =>
                {
                    cp.HasOne(p => p.Person).WithMany(c => c.VisitedCountries).HasForeignKey(p => p.PersonID);
                    cp.HasOne(c => c.Country).WithMany(p => p.Visitors).HasForeignKey(c => c.CountryID);

                    //For Ensuring only 1 entry per person
                    cp.HasAlternateKey(c => new { c.CountryID, c.PersonID });
                });
            */
        }
    }
}
