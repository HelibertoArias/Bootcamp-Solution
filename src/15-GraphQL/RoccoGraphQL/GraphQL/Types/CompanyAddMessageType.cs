// <copyright file="CompanyAddMessageType.cs" company="Rocco Company">
// Copyright (c) 2022, Heliberto Arias
// </copyright>

using GraphQL.Types;
using RoccoGraphQL.GraphQL.Features.Companies.Messaging;

namespace RoccoGraphQL.GraphQL.Types;

public class CompanyAddMessageType : ObjectGraphType<CompanyAddedMessage>
{
    public CompanyAddMessageType()
    {
        Field(x => x.Id);
        Field(x => x.Name);
    }
}
