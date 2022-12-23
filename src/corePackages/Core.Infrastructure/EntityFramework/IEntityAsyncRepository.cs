﻿using Core.Domain.Entities.Abstract;
using Core.Infrastructure.Paging;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace Core.Infrastructure.EntityFramework
{
    public interface IEntityAsyncRepository<T> : IQuery<T> where T : class, IEntity, new()
    {
        Task<T?> GetAsync(Expression<Func<T, bool>> predicate);

        Task<IPaginate<T>> GetListAsync(Expression<Func<T, bool>>? predicate = null,
                                        Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
                                        Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
                                        int index = 0, int size = 10, bool enableTracking = true,
                                        CancellationToken cancellationToken = default);

        Task<IPaginate<T>> GetListByDynamicAsync(Dynamic.Dynamic dynamic,
                                                 Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
                                                 int index = 0, int size = 10, bool enableTracking = true,
                                                 CancellationToken cancellationToken = default);

        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);
    }
}
