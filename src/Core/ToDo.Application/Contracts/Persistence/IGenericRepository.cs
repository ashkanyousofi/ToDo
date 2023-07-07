
namespace ToDo.Application.Contracts.Persistence
{
	public interface IGenericRepository<T> where T : BaseEntity
	{
		Task<IReadOnlyList<T>> GetAll();
		Task<T> Get(Func<string,bool> query);
		Task<T> Get(string id);
		Task<T>Update(T entity);
		Task<T> Add(T entity);
		Task<bool> Delete(T entity);
		
	}
}
