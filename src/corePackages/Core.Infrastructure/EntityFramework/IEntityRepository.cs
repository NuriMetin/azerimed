﻿using Core.Domain.Entities.Abstract;
using Core.Infrastructure.Paging;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Infrastructure.EntityFramework
{
    public interface IEntityRepository<T> : IQuery<T> where T : class, IEntity, new()
    {
        T Get(Expression<Func<T, bool>> predicate);

        IPaginate<T> GetList(Expression<Func<T, bool>>? predicate = null,
                             Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
                             Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
                             int index = 0, int size = 10,
                             bool enableTracking = true);

        IPaginate<T> GetListByDynamic(Dynamic.Dynamic dynamic,
                                      Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
                                      int index = 0, int size = 10, bool enableTracking = true);

        T Add(T entity);
        T Update(T entity);
        T Delete(T entity);
    }
}