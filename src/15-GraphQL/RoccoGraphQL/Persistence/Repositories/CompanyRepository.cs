// <copyright file="CompanyRepository.cs" company="Rocco Company">
// Copyright (c) 2022, Heliberto Arias
// </copyright>

using RoccoGraphQL.Application.Contracts.Persistence;
using RoccoGraphQL.Domain.Entities;
using RoccoGraphQL.Persistence.Repositories.Common;

namespace RoccoGraphQL.Persistence.Repositories;
public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
{
    public CompanyRepository(RoccoContext repositoryContext) : base(repositoryContext)
    {
    }
}
