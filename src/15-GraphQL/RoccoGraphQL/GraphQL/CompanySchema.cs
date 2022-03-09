// <copyright file="CompanySchema.cs" company="Rocco Company">
// Copyright (c) 2022, Heliberto Arias
// </copyright>

using GraphQL.Types;

namespace RoccoGraphQL.GraphQL;

public class CompanySchema : Schema
{
    public CompanySchema(IServiceProvider resolver) : base(resolver)
    {
        Query = resolver.GetRequiredService<CompanyQuery>();
        
    }
}
