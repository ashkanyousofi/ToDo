
namespace ToDo.Persistence.Repositories.Dapper
{
	public class RoleRepositoryDapper : IRoleRepositoryDapper
	{
		//private readonly string _connectionString = @"Server=.;Initial Catalog=ToDoDB ;Integrated Security=true;";
		private readonly string _connectionString = @"Data Source =.; Initial Catalog = ToDoDB; Integrated Security = True; TrustServerCertificate=True";
		public async Task<Role> Add(Domain.Entities.Role.Role role)
		{
			try
			{
				#region Insert Data
				string query = @"INSERT INTO Plan (Id,Time,Title,IsNotification,UserId,Description,CreateDate) Values
					(@Id,@Time,@Title,@IsNotification,@UserId,@Description,@CreateDate)";
				var connection = new SqlConnection(_connectionString);

				var result = await connection.ExecuteAsync(query, new
				{
					role.Id,
					role.Title,
					role.Description,
					role.CreateDate,
				});
				#endregion

				#region Get Data
				query = @$"SELECT * FROM Plan WHERE Id=@Id";
				Role response = (Role)await connection.QueryAsync(query, new
				{
					Id = role.Id,
				});
				#endregion
				return response;
			}
			catch (Exception)
			{
				throw new Exception();
			}
		}

		public async Task<bool> Delete(Role role)
		{
			try
			{
				#region Get Data
				string query = @"DELETE FROM Plan WHERE Id=@Id";
				var connection = new SqlConnection(_connectionString);
				var result = await connection.ExecuteAsync(query, new { Id = role.Id });
				#endregion
				return result == 1 ? true : false;
			}
			catch (Exception)
			{
				throw new Exception();
			}
		}

		public async Task<List<Role>> Get(Func<Role, bool> operation)
		{
			try
			{
				#region Get Data
				string query = @"SELECT * FROM Plan";
				var connection = new SqlConnection(_connectionString);
				List<Role> result = (List<Role>)await connection.QueryAsync(query);
				#endregion
				return result.Where(operation).ToList();
			}
			catch (Exception)
			{
				throw new Exception();
			}
		}

		public async Task<Role> Get(string id)
		{
			try
			{
				#region Get Data
				string query = @"SELECT * FROM Plan WHERE Id==@Id";
				var connection = new SqlConnection(_connectionString);
				Role result = (Role)await connection.QueryAsync(query, new { Id = id, });
				#endregion
				return result;
			}
			catch (Exception)
			{
				throw new Exception();
			}
		}

		public async Task<List<Role>> GetAllPlansByUserId(string userId)
		{
			try
			{
				#region Get Data
				string query = @"SELECT * FROM Plan WHERE UserId==@UserId";
				var connection = new SqlConnection(_connectionString);
				List<Role> result = (List<Role>)await connection.QueryAsync(query, new { UserId = userId, });
				#endregion
				return result;
			}
			catch (Exception)
			{
				throw new Exception();
			}
		}

		public Task<List<Role>> GetAllRoles()
		{
			throw new NotImplementedException();
		}

		public Task<IQueryable<Role>> GetRolesOfUser(string userId)
		{
			throw new NotImplementedException();
		}

		public async Task<Role> Update(Role role)
		{
			try
			{
				#region Insert Data
				string query = @"UPDATE Plan SET Id=@Id,Time=@Time,
				Title=@Title,IsNotification=@IsNotification,UserId=@UserId,
				Description=@Description,CreateDate=@CreateDate WHERE Id=@Id";

				var connection = new SqlConnection(_connectionString);

				var result = await connection.ExecuteAsync(query, new
				{
					Id = role.Id,
					Title = role.Title,
					Description = role.Description,
					CreateDate = role.CreateDate,
				});
				#endregion

				#region Get Data
				query = @$"SELECT * FROM Plan WHERE Id==@Id";
				Role response = (Role)await connection.QueryAsync(query, new
				{
					Id = role.Id,
				});
				#endregion
				return response;
			}
			catch (Exception)
			{
				throw new Exception();
			}
		}
	}
}
