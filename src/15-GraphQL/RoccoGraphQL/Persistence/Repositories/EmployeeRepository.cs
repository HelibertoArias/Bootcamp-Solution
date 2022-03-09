// <copyright file="EmployeeRepository.cs" company="Rocco Company">
// Copyright (c) 2022, Heliberto Arias
// </copyright>

using Microsoft.EntityFrameworkCore;
using RoccoGraphQL.Application.Contracts.Persistence;
using RoccoGraphQL.Domain.Entities;
using RoccoGraphQL.Persistence.Repositories.Common;

namespace RoccoGraphQL.Persistence.Repositories;

public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
{
    public EmployeeRepository(RoccoContext repositoryContext) : base(repositoryContext)
    {

    }
    // More about how to use ILookup https://bit.ly/3pOIlhk
    public async Task<ILookup<Guid, Employee>> GetEmployeesByCompanyId(IEnumerable<Guid> companiesIds)
    {
        var employees = await _dbContext.Employees
                                .AsNoTracking()
                                .Where(x => companiesIds.Contains(x.CompanyId))
                                .ToListAsync()
                                .ConfigureAwait(false);

        return employees.ToLookup(x => x.CompanyId);
    }
}
