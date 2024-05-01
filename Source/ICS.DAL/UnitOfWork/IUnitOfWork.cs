﻿using ICS.DAL.Entities;
using ICS.DAL.Mappers;
using ICS.DAL.Repositories;

namespace ICS.DAL.UnitOfWork;

public interface IUnitOfWork : IAsyncDisposable
{
    public IRepository<TEntity> GetRepository<TEntity, TEntityMapper>()
        where TEntity : class, IEntity
        where TEntityMapper : IEntityMapper<TEntity>, new();

    public Task CommitAsync();
}
