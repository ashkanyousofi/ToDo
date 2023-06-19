using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Entities.Common;

namespace ToDo.Application.Persistence.Contracts
{
	public interface IGenericRepository<T>where T : BaseEntity
	{
		Task<IReadOnlyList<T>> GetAll();
		Task<T> Get(string id);
		Task<T>Update(T entity);
		Task<T> Add(T entity);
		Task<bool> Delete(T entity);
		
	}
}
