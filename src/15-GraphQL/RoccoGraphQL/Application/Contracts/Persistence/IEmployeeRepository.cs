// <copyright file="IEmployeeRepository.cs" company="Rocco Company">
// Copyright (c) 2022, Heliberto Arias
// </copyright>

using RoccoGraphQL.Application.Contracts.Persistence.Common;
using RoccoGraphQL.Domain.Entities;

namespace RoccoGraphQL.Application.Contracts.Persistence;

public interface IEmployeeRepository : IRepositoryBase<Employee>
{
}
