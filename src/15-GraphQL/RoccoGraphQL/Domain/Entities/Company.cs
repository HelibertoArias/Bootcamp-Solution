// <copyright file="Company.cs" company="Rocco Company">
// Copyright (c) 2022, Heliberto Arias
// </copyright>

using RoccoGraphQL.Domain.Base;

namespace RoccoGraphQL.Domain.Entities;

public class Company : AuditableEntity
{
    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Country { get; set; } = null!;

    public ICollection<Employee> Employees { get; set; } = null!;
}
