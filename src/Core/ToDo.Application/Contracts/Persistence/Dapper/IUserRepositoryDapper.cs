using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Entities.ToDo;
using ToDo.Domain.Entities.User;

namespace ToDo.Application.Contracts.Persistence.Dapper
{
    public interface IUserRepositoryDapper
    {
        Task<List<User>> Get(Func<User, bool> operation);
        Task<User> Get(string id);
        Task<User> Update(Plan user);
        Task<User> Add(Plan user);
        Task<bool> Delete(Plan user);
        Task<List<User>> GetAllUser();
    }
}
