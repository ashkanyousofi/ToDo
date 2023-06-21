using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Entities.ToDo;

namespace ToDo.Application.Contracts.Persistence
{
	public interface IManageToDo : IGenericRepository<Plan>
	{
		Task<List<Plan>> GetAllPlansById(string id);
	}
}
