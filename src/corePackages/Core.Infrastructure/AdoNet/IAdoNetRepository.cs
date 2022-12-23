using Core.Domain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Infrastructure.AdoNet
{
    public interface IAdoNetRepository<T> where T : class, IEntity, new()
    {
        public IEnumerable<T> GetList<T>(string commandQuery, string connectionString);
        public T Get<T>(string commandQuery, string connectionString);
        public void ExecuteCommand(string commandQuery, string connectionString);
    }
}
