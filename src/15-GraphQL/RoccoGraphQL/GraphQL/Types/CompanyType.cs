// <copyright file="CompanyType.cs" company="Rocco Company">
// Copyright (c) 2022, Heliberto Arias
// </copyright>

using GraphQL.Types;
using RoccoGraphQL.Domain.Entities;

namespace RoccoGraphQL.GraphQL.Types;

public class CompanyType: ObjectGraphType<Company>
{
    public CompanyType()
    {
        Name = "Company";
        Description = "Company Type";
        //Field(x => x.Id);
        Field(x => x.Name);
        Field(x=>x.Address);
        Field(x=>x.Country);
    }
}
