// <copyright file="CompanyType.cs" company="Rocco Company">
// Copyright (c) 2022, Heliberto Arias
// </copyright>

using GraphQL.Types;
using RoccoGraphQL.Domain.Entities;

namespace RoccoGraphQL.GraphQL.Types;

public class EmployeeType: ObjectGraphType<Employee>
{
    public EmployeeType()
    {
        Name = nameof(Employee);
        Field(x => x.Id);
        Description = "Employee Type";
        Field(x => x.Name).Description("The name of the employee");
        
    }
}
