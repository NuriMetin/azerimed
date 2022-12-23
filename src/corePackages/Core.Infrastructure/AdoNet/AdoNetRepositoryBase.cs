using Core.Domain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Core.Infrastructure.AdoNet
{
    public class AdoNetRepositoryBase<TEntity> : IAdoNetAsyncRepository<TEntity>, IAdoNetRepository<TEntity> where TEntity : class, IEntity, new()
    {
        public void ExecuteCommand(string commandQuery, string connectionString)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(commandQuery, sqlConnection))
                {
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Dispose();
                }
                sqlConnection.Close();
            }
        }

        public async Task ExecuteCommandAsync(string commandQuery, string connectionString)
        {
            await using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                await sqlConnection.OpenAsync();

                await using (SqlCommand sqlCommand = new SqlCommand(commandQuery, sqlConnection))
                {
                    sqlCommand.CommandTimeout = 300;
                    await sqlCommand.ExecuteNonQueryAsync();
                    await sqlCommand.DisposeAsync();
                }
                await sqlConnection.CloseAsync();
            }
        }

        public T Get<T>(string commandQuery, string connectionString)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(commandQuery, sqlConnection))
                {
                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        return GetRecord<T>(dataReader);
                    }
                    sqlCommand.Dispose();
                }
                sqlConnection.Close();
            }
        }

        public async Task<T> GetAsync<T>(string commandQuery, string connectionString)
        {
            await using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                await sqlConnection.OpenAsync();

                await using (SqlCommand sqlCommand = new SqlCommand(commandQuery, sqlConnection))
                {
                    await using (SqlDataReader dataReader = await sqlCommand.ExecuteReaderAsync())
                    {
                        return await GetRecordAsync<T>(dataReader);
                    }
                    await sqlCommand.DisposeAsync();
                }
                await sqlConnection.CloseAsync();
            }
        }

        public IEnumerable<T> GetList<T>(string commandQuery, string connectionString)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(commandQuery, sqlConnection))
                {
                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        return GetRecords<T>(dataReader);
                    }
                    sqlCommand.Dispose();
                }
                sqlConnection.Close();
            }
        }

        public async Task<IEnumerable<T>> GetListAsync<T>(string commandQuery, string connectionString)
        {
            await using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                await sqlConnection.OpenAsync();

                await using (SqlCommand sqlCommand = new SqlCommand(commandQuery, sqlConnection))
                {
                    await using (SqlDataReader dataReader = await sqlCommand.ExecuteReaderAsync())
                    {
                        return await GetRecordsAsync<T>(dataReader);
                    }
                    await sqlCommand.DisposeAsync();
                }
                await sqlConnection.CloseAsync();
            }
        }

        private IEnumerable<T> GetRecords<T>(SqlDataReader dataReader)
        {
            List<T> ret = new List<T>();

            IEnumerable<PropertyInfo> columns = GetProperties<T>(dataReader);

            while (dataReader.Read())
            {
                T entity = Activator.CreateInstance<T>();

                if (columns.Count() > 0)
                {
                    for (int i = 0; i < columns.Count(); i++)
                    {
                        if (dataReader[columns.ElementAt(i).Name].Equals(DBNull.Value))
                            columns.ElementAt(i).SetValue(entity, null, null);

                        else
                            columns.ElementAt(i).SetValue(entity, dataReader[columns.ElementAt(i).Name], null);
                    }
                }

                else
                {
                    if (dataReader[0].Equals(DBNull.Value))
                        entity = default;

                    else
                        entity = (T)dataReader[0];
                }

                ret.Add(entity);
            }
            return ret;
        }

        private async Task<IEnumerable<T>> GetRecordsAsync<T>(SqlDataReader dataReader)
        {
            List<T> ret = new List<T>();

            IEnumerable<PropertyInfo> columns = GetProperties<T>(dataReader);

            while (await dataReader.ReadAsync())
            {
                T entity = Activator.CreateInstance<T>();

                if (columns.Count() > 0)
                {
                    for (int i = 0; i < columns.Count(); i++)
                    {
                        if (dataReader[columns.ElementAt(i).Name].Equals(DBNull.Value))
                            columns.ElementAt(i).SetValue(entity, null, null);

                        else
                            columns.ElementAt(i).SetValue(entity, dataReader[columns.ElementAt(i).Name], null);
                    }
                }

                else
                {
                    if (dataReader[0].Equals(DBNull.Value))
                        entity = default;

                    else
                        entity = (T)dataReader[0];
                }

                ret.Add(entity);
            }
            return ret;
        }

        private T GetRecord<T>(SqlDataReader dataReader)
        {
            T entity = Activator.CreateInstance<T>();

            IEnumerable<PropertyInfo> columns = GetProperties<T>(dataReader);

            while (dataReader.Read())
            {
                if (columns.Count() > 0)
                {
                    for (int i = 0; i < columns.Count(); i++)
                    {
                        if (dataReader[columns.ElementAt(i).Name].Equals(DBNull.Value))
                            columns.ElementAt(i).SetValue(entity, null, null);

                        else
                            columns.ElementAt(i).SetValue(entity, dataReader[columns.ElementAt(i).Name], null);
                    }
                }

                else
                {
                    if (dataReader[0].Equals(DBNull.Value))
                        entity = default;

                    else
                        entity = (T)dataReader[0];
                }
            }
            return entity;
        }

        private async Task<T> GetRecordAsync<T>(SqlDataReader dataReader)
        {
            T entity = Activator.CreateInstance<T>();

            IEnumerable<PropertyInfo> columns = GetProperties<T>(dataReader);

            while (await dataReader.ReadAsync())
            {
                if (columns.Count() > 0)
                {
                    for (int i = 0; i < columns.Count(); i++)
                    {
                        if (dataReader[columns.ElementAt(i).Name].Equals(DBNull.Value))
                            columns.ElementAt(i).SetValue(entity, null, null);

                        else
                            columns.ElementAt(i).SetValue(entity, dataReader[columns.ElementAt(i).Name], null);
                    }
                }

                else
                {
                    if (dataReader[0].Equals(DBNull.Value))
                        entity = default;

                    else
                        entity = (T)dataReader[0];
                }
            }
            return entity;
        }

        private IEnumerable<PropertyInfo> GetProperties<T>(IDataReader rdr)
        {
            Type typ = typeof(T);

            for (int index = 0; index < rdr.FieldCount; index++)
            {
                PropertyInfo col = typ.GetProperties().FirstOrDefault(c => c.Name == rdr.GetName(index));

                if (col != null)
                {
                    yield return col;
                }
            }
        }
    }
}