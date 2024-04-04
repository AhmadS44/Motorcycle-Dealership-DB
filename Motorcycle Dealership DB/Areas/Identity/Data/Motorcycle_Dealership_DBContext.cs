﻿using Motorcycle_Dealership_DB.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Motorcycle_Dealership_DB.Models;

namespace Motorcycle_Dealership_DB.Areas.Identity.Data;

public class Motorcycle_Dealership_DBContext : IdentityDbContext<IdentityUser>
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
}