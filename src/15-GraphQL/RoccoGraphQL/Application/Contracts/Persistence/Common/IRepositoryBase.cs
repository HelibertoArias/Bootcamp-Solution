// <copyright file="IRepositoryBase.cs" company="Rocco Company">
// Copyright (c) 2022, Heliberto Arias
// </copyright>

using System.Linq.Expressions;
using RoccoGraphQL.Domain.Base;

namespace RoccoGraphQL.Application.Contracts.Persistence.Common;

public interface IRepositoryBase<T> where T : class, IEntity
{
    IQueryable<T> FindAll(bool trackChanges);

    IQueryable<T> FindAllByCondition(Expression<Func<T, bool>> expression, bool trackChanges);

    Task<T?> FindOneByCondition(Expression<Func<T, bool>> expression, bool trackChanges);

    Task Add(T entity);

    void Update(T entity);

    void Delete(T entity);

    Task SaveChangesAsync();

    Task<IReadOnlyList<T>> GetPagedReponseAsync(int page, int size);
}
