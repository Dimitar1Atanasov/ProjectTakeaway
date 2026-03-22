using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectTakeaway.Web.Data.Entities;

namespace ProjectTakeaway.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Menu
            modelBuilder.Entity<Menu>(entity =>
            {
                entity.HasKey(m => m.Id);

                entity.Property(m => m.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(m => m.Description)
                    .HasMaxLength(500);

                entity.Property(m => m.ImageUrl)
                    .HasMaxLength(500);

                entity.HasMany(m => m.MenuCategories)
                    .WithOne()
                    .HasForeignKey("MenuId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            // MenuCategory
            modelBuilder.Entity<MenuCategory>(entity =>
            {
                entity.HasKey(mc => mc.Id);

                entity.Property(mc => mc.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(mc => mc.Description)
                    .HasMaxLength(500);

                entity.HasMany(mc => mc.MenuItems)
                    .WithOne(mi => mi.MenuCategory)
                    .HasForeignKey(mi => mi.MenuCategoryId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            // MenuItem
            modelBuilder.Entity<MenuItem>(entity =>
            {
                entity.HasKey(mi => mi.Id);

                entity.Property(mi => mi.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(mi => mi.Description)
                    .HasMaxLength(500);

                entity.Property(mi => mi.ImageUrl)
                    .HasMaxLength(500);

                entity.Property(mi => mi.Price)
                    .HasColumnType("decimal(10,2)")
                    .IsRequired();

                entity.HasOne(mi => mi.MenuCategory)
                    .WithMany(mc => mc.MenuItems)
                    .HasForeignKey(mi => mi.MenuCategoryId)
                    .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}
