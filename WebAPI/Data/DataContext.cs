using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.Xml;
using WebAPI.Models;

namespace WebAPI.Data

{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<SmartPhone> SmartPhones { get; set; }
        public DbSet<SmartPhoneOwner> SmartPhoneOwners { get; set; }
        public DbSet<SmartPhoneCategory> SmartPhoneCategories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Reviewer> Reviewers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SmartPhoneCategory>().HasKey(sc => new {sc.SmartPhoneId, sc.CategoryId});
            modelBuilder.Entity<SmartPhoneCategory>().HasOne(s => s.SmartPhone)
                .WithMany(sc => sc.SmartPhoneCategories)
                .HasForeignKey(sc => sc.SmartPhoneId);
            modelBuilder.Entity<SmartPhoneCategory>().HasOne(s => s.Category)
                .WithMany(sc => sc.SmartPhoneCategories)
                .HasForeignKey(sc => sc.CategoryId);

            modelBuilder.Entity<SmartPhoneOwner>().HasKey(so => new { so.SmartPhoneId, so.OwnerId });
            modelBuilder.Entity<SmartPhoneOwner>().HasOne(s => s.SmartPhone)
                .WithMany(so => so.SmartPhoneOwners)
                .HasForeignKey(so => so.SmartPhoneId);
            modelBuilder.Entity<SmartPhoneOwner>().HasOne(s => s.Owner)
                .WithMany(so => so.SmartPhoneOwners)
                .HasForeignKey(so => so.OwnerId);


        }


    }
}
