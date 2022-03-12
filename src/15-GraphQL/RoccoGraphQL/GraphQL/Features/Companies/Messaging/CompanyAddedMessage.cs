// <copyright file="CompanyAddedMessage.cs" company="Rocco Company">
// Copyright (c) 2022, Heliberto Arias
// </copyright>

namespace RoccoGraphQL.GraphQL.Features.Companies.Messaging;

public class CompanyAddedMessage
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
}
