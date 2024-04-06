using Motorcycle_Dealership_DB.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Motorcycle_Dealership_DB.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Motorcycle_Dealership_DB.Areas.Identity.Data;

public class Motorcycle_Dealership_DBContext : IdentityDbContext<ApplicationUser>
{
    internal object customer;

    public Motorcycle_Dealership_DBContext(DbContextOptions<Motorcycle_Dealership_DBContext> options)
        : base(options)
    {
    }
    

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

public DbSet<Motorcycle_Dealership_DB.Models.Customer> Customer { get; set; } = default!;

public DbSet<Motorcycle_Dealership_DB.Models.Inventory> Inventory { get; set; } = default!;

public DbSet<Motorcycle_Dealership_DB.Models.Locations> Locations { get; set; } = default!;

public DbSet<Motorcycle_Dealership_DB.Models.Motorcycles> Motorcycles { get; set; } = default!;

public DbSet<Motorcycle_Dealership_DB.Models.PurchaseOrder> PurchaseOrder { get; set; } = default!;

public DbSet<Motorcycle_Dealership_DB.Models.Suppliers> Suppliers { get; set; } = default!;
}

public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.Property(u => u.FirstName).HasMaxLength(20);
        builder.Property(u => u.LastName).HasMaxLength(20);
        builder.Property(u => u.PhoneNumber).HasMaxLength(10);

    }
}
