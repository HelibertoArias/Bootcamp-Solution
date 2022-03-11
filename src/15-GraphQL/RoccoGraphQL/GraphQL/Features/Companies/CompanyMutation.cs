// <copyright file="CompanyMutation.cs" company="Rocco Company">
// Copyright (c) 2022, Heliberto Arias
// </copyright>

using GraphQL;
using GraphQL.Types;
using RoccoGraphQL.Application.Contracts.Persistence;
using RoccoGraphQL.Domain.Entities;
using RoccoGraphQL.GraphQL.Types;

namespace RoccoGraphQL.GraphQL.Features.Companies;

public class CompanyMutation : ObjectGraphType
{
    public CompanyMutation(ICompanyRepository companyRepository)
    {      
        FieldAsync<CompanyType>(
            "createCompany",
            arguments: new QueryArguments(new QueryArgument<NonNullGraphType<CompanyInputType>> { Name = "company" }),
            resolve: async context =>
            {
                var company = context.GetArgument<Company>("company");
                await companyRepository.Add(company).ConfigureAwait(false);
                await companyRepository.SaveChangesAsync().ConfigureAwait(false);
                return company;
            });
    }
}
