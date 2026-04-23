using Microsoft.EntityFrameworkCore;
using ClinicVet.Models;
using ClinicVet.App.Data.Models;

namespace ClinicVet.App.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Role> Roles { get; set; }
    public DbSet<AnimalType> AnimalTypes { get; set; }
    
    public DbSet<Worker> Workers { get; set; }
    
    public DbSet<Client> Clients { get; set; }
    public DbSet<Animal> Animals { get; set; }
    public DbSet<Medicine> Medicines { get; set; }
    public DbSet<Visit> Visits { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AnimalType>().HasData(
            new AnimalType { Name = "Dog" },
            new AnimalType { Name = "Cat" },
            new AnimalType { Name = "Parrot" }
        );

        var adminRole = new Role {Name = "admin"};
        
        modelBuilder.Entity<Role>().HasData(
            adminRole,
            new Role { Name = "Veterinarian" },
            new Role { Name = "Assistant" }
        );

        modelBuilder.Entity<Worker>().HasData(new Worker
        {
            Email = "admin@example.com",
            Password = "admin",
            Role = adminRole, Username = "admin", WorkerId = "0000",
            Id = "0"
        });
    }
}