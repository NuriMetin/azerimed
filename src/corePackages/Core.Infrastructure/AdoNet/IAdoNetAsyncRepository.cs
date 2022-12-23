using Core.Domain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Infrastructure.AdoNet
{
    public interface IAdoNetAsyncRepository<T> where T : class, IEntity, new()
    {
        Task<IEnumerable<T>> GetListAsync<T>(string commandQuery, string connectionString);
        Task<T> GetAsync<T>(string commandQuery, string connectionString);
        Task ExecuteCommandAsync(string commandQuery, string connectionString);
    }
}
