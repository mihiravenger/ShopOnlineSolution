using Microsoft.EntityFrameworkCore;
using ShopOnline.Api.Entities;

namespace ShopOnline.Api.Data;

public class ShopOnlineContext : DbContext
{
	public ShopOnlineContext(DbContextOptions<ShopOnlineContext> options) : base(options)
	{

	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

		modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory[]
		{
			new ProductCategory { Id = 1, Name = "Whisky" },
            new ProductCategory { Id = 2, Name = "Vodka" },
            new ProductCategory { Id = 3, Name = "Gin" },
            new ProductCategory { Id = 4, Name = "Rum" },
            new ProductCategory { Id = 5, Name = "Beer" }
        });

        modelBuilder.Entity<Product>().HasData(new Product[]
        {
            new Product { Id = 1, CategoryId = 1, Name = "OakSmith Gold", Description = "International Blended Whisky", ImageURL = "/Images/Whisky/1.png", Price = 1445, Qty = 100 },
            new Product { Id = 2, CategoryId = 1, Name = "Mcdowell's No 1", Description = "Luxury Premium Whisky", ImageURL = "/Images/Whisky/1.png", Price = 640, Qty = 80 },
            new Product { Id = 3, CategoryId = 2, Name = "Magic Moments", Description = "Flavoured Lemon Grass and Ginger", ImageURL = "/Images/Vodka/1.png", Price = 800, Qty = 90 },
            new Product { Id = 4, CategoryId = 2, Name = "Smirnoff", Description = "Plain Classic Vodka", ImageURL = "/Images/Vodka/1.png", Price = 1560, Qty = 100 },
            new Product { Id = 5, CategoryId = 3, Name = "American Duet", Description = "Flavoured Classic Gin", ImageURL = "/Images/Gin/1.png", Price = 400, Qty = 90 },
            new Product { Id = 6, CategoryId = 3, Name = "Bombay Sapphire", Description = "London Dry Gin", ImageURL = "/Images/Gin/1.png", Price = 2450, Qty = 100},
            new Product { Id = 7, CategoryId = 4, Name = "Old Monk Gold", Description = "All Time Classic Dark Rum", ImageURL = "/Images/Rum/1.png", Price = 1445, Qty = 100},
            new Product { Id = 8, CategoryId = 4, Name = "Bacardi White", Description = "White Apple Flavoured Rum", ImageURL = "/Images/Rum/1.png", Price = 1445, Qty = 100},
            new Product { Id = 9, CategoryId = 5, Name = "Kingfisher Ultra", Description = "Mild Beer", ImageURL = "/Images/Beer/1.png", Price = 1445, Qty = 100 },
            new Product { Id = 10, CategoryId = 5, Name = "Budweiser Magnum", Description = "Super Strong Beer", ImageURL = "/Images/Beer/1.png", Price = 1445, Qty = 100 }
        });

        modelBuilder.Entity<User>().HasData(new User[]
        {
            new User { Id = 1, UserName = "Mihir" },
            new User { Id = 2, UserName = "Shreyas" },
            new User { Id = 3, UserName = "Bhavesh" }
        });

        modelBuilder.Entity<Cart>().HasData(new Cart[]
        {
            new Cart { Id = 1, UserId = 1 },
            new Cart { Id = 2, UserId = 2 },
            new Cart { Id = 3, UserId = 3 }
        });
    }

	public DbSet<Cart> Carts { get; set; }
    public DbSet<CartItem> CartItems { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductCategory> ProductCategories { get; set; }
    public DbSet<User> Users { get; set; }
}
