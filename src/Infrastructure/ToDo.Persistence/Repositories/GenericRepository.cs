using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.Contracts.Persistence;
using ToDo.Domain.Entities.Common;

namespace ToDo.Persistence.Repositories
{
	public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
	{
		private readonly string _connectionString = @"Server=.;Initial Catalog=ToDoDB ;Integrated Security=true;";
		public async Task<T> Add(T entity)
		{
			try
			{
				string query = "";
				var connection = new SqlConnection(_connectionString);

				var result = await connection.ExecuteAsync(query);

				query = "";
				T response = (T)await connection.QueryAsync(query);
				return response;
			}
			catch (Exception)
			{
				throw new Exception();
			}
		}

		public Task<bool> Delete(T entity)
		{
			throw new NotImplementedException();
		}

		public Task<T> Get(string id)
		{
			throw new NotImplementedException();
		}

		public Task<T> Get(Func<string, bool> query)
		{
			throw new NotImplementedException();
		}

		public Task<IReadOnlyList<T>> GetAll()
		{
			throw new NotImplementedException();
		}

		public Task<T> Update(T entity)
		{
			throw new NotImplementedException();
		}
	}
}
