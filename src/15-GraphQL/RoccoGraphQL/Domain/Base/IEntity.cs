// <copyright file="IEntity.cs" company="Rocco Company">
// Copyright (c) 2022, Heliberto Arias
// </copyright>

namespace RoccoGraphQL.Domain.Base;
public interface IEntity
{
    Guid Id { get; set; }
}
