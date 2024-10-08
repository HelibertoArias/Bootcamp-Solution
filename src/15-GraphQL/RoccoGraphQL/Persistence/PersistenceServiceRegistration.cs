// <copyright file="PersistenceServiceRegistration.cs" company="Rocco Company">
// Copyright (c) 2022, Heliberto Arias
// </copyright>

using Microsoft.EntityFrameworkCore;
using RoccoGraphQL.Application.Contracts.Persistence;
using RoccoGraphQL.Persistence.Repositories;

namespace RoccoGraphQL.Persistence;
public static class PersistenceServiceRegistration
{
    // IConfiguration : https://bit.ly/3uXRpUJ

    public static IServiceCollection AddPersistenceServices(this IServiceCollection services,
                                IConfiguration configuration)
    {
        // Connection String
        var stringConnection = "RoccoConnectionString";
        var connectionConfiguration = configuration.GetConnectionString(stringConnection);
        if (connectionConfiguration == null)
        {
            throw new ArgumentNullException(nameof(connectionConfiguration).ToString(),
                    message: $"{stringConnection} doesn't exist in your appsetings.json");
        }
        services.AddDbContext<RoccoContext>(options =>
          options.UseSqlServer(connectionConfiguration)
            .EnableSensitiveDataLogging() // This allow to see the SQL operations in console
        );

        // Setting up repositories
        // Registering by one
        services.AddScoped<ICompanyRepository, CompanyRepository>();
        services.AddScoped<IEmployeeRepository, EmployeeRepository>();

        // Registering dynamically
        //services.AddTransient(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
        return services;
    }
}
