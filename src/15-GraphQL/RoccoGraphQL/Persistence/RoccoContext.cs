// <copyright file="RoccoContext.cs" company="Rocco Company">
// Copyright (c) 2022, Heliberto Arias
// </copyright>

using System.Reflection;
using Microsoft.EntityFrameworkCore;
using RoccoGraphQL.Domain.Base;
using RoccoGraphQL.Domain.Entities;

namespace RoccoGraphQL.Persistence;

// Working with DbContext - EF6 : https://bit.ly/3gUZK3k
public class RoccoContext : DbContext
{
    public RoccoContext(DbContextOptions<RoccoContext> options) : base(options)
    {
        if (options is null)
        {
            throw new ArgumentNullException(nameof(options));
        }

    }

    public DbSet<Company> Companies { get; set; } = null!;

    public DbSet<Employee> Employees { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Please put this in the Rocco.Persistence/Configuration folder
        // modelBuilder.Entity<Employee>().HasKey(x => x.Id);

        // Add All entity configurations in a dynamic way 
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreatedDate = DateTime.Now;
                    entry.Entity.CreatedBy = "JohnDoe";
                    entry.Entity.IsDeleted = false;
                    break;
                case EntityState.Modified:
                    entry.Entity.LastModifiedDate = DateTime.Now;
                    entry.Entity.LastModifiedBy = "JaneDoe";
                    break;
            }
        }
        return base.SaveChangesAsync(cancellationToken);
    }
}

