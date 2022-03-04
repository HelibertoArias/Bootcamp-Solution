// <copyright file="Employee.cs" company="Rocco Company">
// Copyright (c) 2022, Heliberto Arias
// </copyright>

using RoccoGraphQL.Domain.Base;

namespace RoccoGraphQL.Domain.Entities;
public class Employee : AuditableEntity
{
    public string Name { get; set; } = null!;

    public int Age { get; set; }

    public string Position { get; set; } = null!;

    public Guid CompanyId { get; set; }

    public Company Company { get; set; } = null!;
}

