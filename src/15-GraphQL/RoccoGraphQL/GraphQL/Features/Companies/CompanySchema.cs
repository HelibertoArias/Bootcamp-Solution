// <copyright file="CompanySchema.cs" company="Rocco Company">
// Copyright (c) 2022, Heliberto Arias
// </copyright>

using GraphQL.Types;
using RoccoGraphQL.GraphQL.Features.Companies.Messaging;

namespace RoccoGraphQL.GraphQL.Features.Companies;

public class CompanySchema : Schema
{
    public CompanySchema(IServiceProvider resolver) : base(resolver)
    {
        Query = resolver.GetRequiredService<CompanyQuery>();
        Mutation = resolver.GetRequiredService<CompanyMutation>();
        Subscription = resolver.GetRequiredService<CompanySubscription>();

    }
}
