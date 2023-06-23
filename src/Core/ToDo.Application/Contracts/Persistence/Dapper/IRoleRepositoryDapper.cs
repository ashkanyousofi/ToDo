using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.Utilities.Enums.Roles;
using ToDo.Domain.Entities.Role;
using ToDo.Domain.Entities.ToDo;

namespace ToDo.Application.Contracts.Persistence.Dapper
{
    public interface IRoleRepositoryDapper
    {
        Task<List<Role>> Get(Func<Role, bool> operation);
        Task<Role> Get(string id);
        Task<Role> Update(Role role);
        Task<Role> Add(Role role);
        Task<bool> Delete(Role role);
        Task<List<Role>> GetAllRoles();
    }
}
