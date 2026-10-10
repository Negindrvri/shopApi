using Microsoft.EntityFrameworkCore;
using shopApi.Entities;

namespace shopApi.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {

    }

    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<UserRole> UserRoles{ get; set; }
    public DbSet<ProductCategory> ProductCategorys { get; set; }
    public DbSet<Product> Product { get; set; }
    public DbSet<ProductImage> ProductImages { get; set; }
    public DbSet<Slider> Sliders { get; set; }

}
