using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.Contracts.Persistence;
using ToDo.Domain.Entities.Common;
using ToDo.Persistence.Context;

namespace ToDo.Persistence.Repositories
{
	public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
	{
		private readonly ToDoContext _context;
        public GenericRepository(ToDoContext context)
        {
			_context = context;
        }
        public async Task<T> Add(T entity)
		{
			throw new NotImplementedException();
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
