
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
        Task<IQueryable<Role>> GetRolesOfUser(string userId);
	}
}
