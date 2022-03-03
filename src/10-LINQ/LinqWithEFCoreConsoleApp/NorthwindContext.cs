using Microsoft.EntityFrameworkCore;

namespace LinqWithEFCoreConsoleApp;

// https://docs.microsoft.com/en-us/ef/core/
public class NorthwindContext : DbContext
{
    public DbSet<Category>? Categories { get; set; }

    public DbSet<Product>? Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
     
        // https://www.connectionstrings.com/sql-server/
        optionsBuilder.UseSqlServer(@"Server= localhost\SQLEXPRESS;Database=Northwind;User Id=sa;Password=P4ss" 
             
            );

    }
}

