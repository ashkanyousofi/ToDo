
namespace ToDo.Application.Contracts.Persistence.Dapper
{
    public interface IManageToDoDapper
    {
        Task<List<Plan>> Get(Func<Plan, bool> operation);
        Task<Plan> Get(string id);
        Task<Plan> Update(Plan plan);
        Task<Plan> Add(Plan plan);
        Task<bool> Delete(Plan plan);
        Task<List<Plan>> GetAllPlansByUserId(string userId);
    }
}
