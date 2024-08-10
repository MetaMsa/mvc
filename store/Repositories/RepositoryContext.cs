using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repositories
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public RepositoryContext(DbContextOptions<RepositoryContext> options)
        : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
            .HasData(
                new Product() { ProductId = 1, ProductName = "Computer", Price = 17_000, ProductImage = "https://www.izoly.com/wp-content/uploads/2024/02/izoly-sirius-x-i5-3470-8gb-128-ssd-22-masaustu-bilgisayar-31184.jpg" },
                new Product() { ProductId = 2, ProductName = "Keyboard", Price = 1_000, ProductImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTTDH12o62myeeJBYku4Gw5lB3JSNqB0uOvqQ&s" },
                new Product() { ProductId = 3, ProductName = "Mouse", Price = 500, ProductImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRL7GhgSU4eiL3PpyRIrMvy3pSV4A-mw1L5Ig&s" },
                new Product() { ProductId = 4, ProductName = "Monitor", Price = 7_000, ProductImage = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/lg/thumb/139112-2_large.jpg" },
                new Product() { ProductId = 5, ProductName = "Deck", Price = 1_500, ProductImage = "https://www.pcworld.com/wp-content/uploads/2023/07/steam_deck_desktop.jpg?quality=50&strip=all" },
                new Product() { ProductId = 6, ProductName = "Camera", Price = 5_000, ProductImage = "https://cdn.akakce.com/sony/sony-hxr-nx200-profesyonel-kamera-z.jpg" }
            );

            modelBuilder.Entity<Category>()
            .HasData(
                new Category() { CategoryId = 1, CategoryName = "Book" },
                new Category() { CategoryId = 2, CategoryName = "Electronic" }
            );
        }
    }
}
