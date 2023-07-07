
namespace ToDo.Application.Contracts.Persistence.Dapper
{
    public interface IUserRepositoryDapper
    {
        Task<bool> GenerateToken(string userId, string token);
		Task<List<User>> Get(Func<User, bool> operation);
        Task<User> Get(string id);
        Task<User> Update(User user);
        Task<User> Add(User user);
        Task<bool> Delete(User user);
        Task<List<User>> GetAllUser();
    }
}
