// <copyright file="CompanySubscription.cs" company="Rocco Company">
// Copyright (c) 2022, Heliberto Arias
// </copyright>

using GraphQL.Resolvers;
using GraphQL.Types;
using RoccoGraphQL.GraphQL.Types;

namespace RoccoGraphQL.GraphQL.Features.Companies.Messaging;

public class CompanySubscription : ObjectGraphType
{
    public CompanySubscription(CompanyMessageService messageService)
    {
        Name = "Subscription";
        AddField(new EventStreamFieldType
        {
            Name = "companyAdded",
            Type = typeof(CompanyAddMessageType),
            Resolver = new FuncFieldResolver<CompanyAddedMessage>(
                c => c.Source as CompanyAddedMessage),
            Subscriber = new EventStreamResolver<CompanyAddedMessage>(c =>
                messageService.GetMessages())
        });
    }
}
