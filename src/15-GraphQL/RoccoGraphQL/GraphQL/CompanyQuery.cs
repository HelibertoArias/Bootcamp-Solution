// <copyright file="CompanyQuery.cs" company="Rocco Company">
// Copyright (c) 2022, Heliberto Arias
// </copyright>

using GraphQL;
using GraphQL.Types;
using RoccoGraphQL.Application.Contracts.Persistence;
using RoccoGraphQL.GraphQL.Types;

namespace RoccoGraphQL.GraphQL;

public class CompanyQuery : ObjectGraphType
{
    public CompanyQuery(ICompanyRepository companyRepository)
    {
        Field<ListGraphType<CompanyType>>(
            name: "companies",
            resolve: context => companyRepository.FindAll(false)
        );

        Field<CompanyType>(
            name: "company",
            arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>>
            { Name = "id" }),
            resolve: context =>
           {
               var id = context.GetArgument<Guid>("id");
               return companyRepository.FindOneByCondition(x => x.Id == id, false);
           });
    }
}
