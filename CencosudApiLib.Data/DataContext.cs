using CencosudApiLib.Models;
using CencosudApiLib.Models.Auth;
using CencosudProjectLib.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace CencosudApiLib.Data;

public class DataContext : IdentityDbContext<User>
{
    public DbSet<Endpoint> Endpoints { get; set; }
    public DbSet<Api> Apis { get; set; }
    public DbSet<ApiInstance> ApiInstances { get; set; }
    public DbSet<ComponentInstance> ComponentInstance { get; set; }
    public DbSet<Project> Projects { get; set; }

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);

    // Seed Identity roles (already in your code)
    modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
    {
        Id = "2c5e174e-3b0e-446f-86af-483d56fd7210",
        Name = "Admin",
        NormalizedName = "ADMIN".ToUpper()
    });
    modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
    {
        Id = "2c5e174e-3b0e-446f-86af-483d56fd7211",
        Name = "Player",
        NormalizedName = "PLAYER".ToUpper()
    });

    // Seed Projects
    modelBuilder.Entity<Project>().HasData(
        new Project { Id = 1, Name = "E-Commerce Platform", Description = "A platform for online shopping", Status = "Active" },
        new Project { Id = 2, Name = "Internal API Management", Description = "System to manage internal APIs", Status = "Development" },
        new Project { Id = 3, Name = "Mobile App", Description = "Mobile application for managing orders", Status = "Testing" }
    );

    // Seed Apis
    modelBuilder.Entity<Api>().HasData(
        new Api { Id = 1, Name = "Authentication API", Description = "API for user authentication", BaseUrl = "https://auth.api.com", Version = "v1.0" },
        new Api { Id = 2, Name = "Payment API", Description = "API for payment processing", BaseUrl = "https://payment.api.com", Version = "v2.1" },
        new Api { Id = 3, Name = "Notification API", Description = "API for sending notifications", BaseUrl = "https://notify.api.com", Version = "v1.3" }
    );

    // Seed ApiInstances
    modelBuilder.Entity<ApiInstance>().HasData(
        new ApiInstance { ProjectId = 1, ApiId = 1},
        new ApiInstance { ProjectId = 1, ApiId = 2},
        new ApiInstance { ProjectId = 2, ApiId = 1},
        new ApiInstance { ProjectId = 2, ApiId = 3},
        new ApiInstance { ProjectId = 3, ApiId = 3}
    );

    // Optionally seed Users (as already in your code)
    var hasher = new PasswordHasher<IdentityUser>();
    for (int i = 1; i <= 12; i++)
    {
        var user = new User
        {
            Id = Guid.NewGuid().ToString(), // primary key
            UserName = $"user{i}",
            NormalizedUserName = $"USER{i}",
            Email = $"user{i}@example.com",
            NormalizedEmail = $"USER{i}@EXAMPLE.COM",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "Password@123"),
            SecurityStamp = string.Empty,
            Name = $"User {i}",
            RegisteredAt = DateTime.Now,
        };

        modelBuilder.Entity<User>().HasData(user);

        modelBuilder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7211", // Player Role
                UserId = user.Id
            }
        );
    }
}

}