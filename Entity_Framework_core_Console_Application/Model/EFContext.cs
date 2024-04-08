using Microsoft.EntityFrameworkCore;

namespace Entity_Framework_core_Console_Application.Model;

/// <summary>
/// Represents the database context for the application.
/// </summary>
public class EFContext : DbContext
{
    private const string connectionString = ""; // Replace with your actual connection string

    /// <summary>
    /// Configures the database connection.
    /// </summary>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connectionString);
    }

    /// <summary>
    /// Gets or sets the products DbSet.
    /// </summary>
    public DbSet<Product> Products { get; set; }
}