
namespace ToDo.Persistence.Repositories.Dapper
{
	public class UserRepositoryDapper : IUserRepositoryDapper
	{
		//private readonly string _connectionString = @"Server=.;Initial Catalog=ToDoDB ;Integrated Security=true;";
		private readonly string _connectionString = @"Data Source =.; Initial Catalog = ToDoDB; Integrated Security = True; TrustServerCertificate=True";
		public async Task<User> Add(User user)
		{
			try
			{
				#region Insert Data
				string query = @"INSERT INTO Plan (Id,Time,Title,IsNotification,UserId,Description,CreateDate) Values
					(@Id,@Time,@Title,@IsNotification,@UserId,@Description,@CreateDate)";
				var connection = new SqlConnection(_connectionString);

				var result = await connection.ExecuteAsync(query, new
				{
					user.Id,
					user.CreateDate,
				});
				#endregion

				#region Get Data
				query = @$"SELECT * FROM Plan WHERE Id=@Id";
				User response = (User)await connection.QueryAsync(query, new
				{
					Id = user.Id,
				});
				#endregion
				return response;
			}
			catch (Exception)
			{
				throw new Exception();
			}
		}

		public async Task<bool> Delete(User user)
		{
			try
			{
				#region Get Data
				string query = @"DELETE FROM Plan WHERE Id=@Id";
				var connection = new SqlConnection(_connectionString);
				var result = await connection.ExecuteAsync(query, new { Id = user.Id });
				#endregion
				return result == 1 ? true : false;
			}
			catch (Exception)
			{
				throw new Exception();
			}
		}

		public Task<bool> GenerateToken(string userId, string token)
		{
			throw new NotImplementedException();
		}

		public async Task<List<User>> Get(Func<User, bool> operation)
		{
			try
			{
				#region Get Data
				string query = @"SELECT * FROM Plan";
				var connection = new SqlConnection(_connectionString);
				List<User> result = (List<User>)await connection.QueryAsync(query);
				#endregion
				return result.Where(operation).ToList();
			}
			catch (Exception)
			{
				throw new Exception();
			}
		}

		public async Task<User> Get(string id)
		{
			try
			{
				#region Get Data
				string query = @"SELECT * FROM Plan WHERE Id==@Id";
				var connection = new SqlConnection(_connectionString);
				User result = (User)await connection.QueryAsync(query, new { Id = id, });
				#endregion
				return result;
			}
			catch (Exception)
			{
				throw new Exception();
			}
		}

		public async Task<List<User>> GetAllPlansByUserId(string userId)
		{
			try
			{
				#region Get Data
				string query = @"SELECT * FROM Plan WHERE UserId==@UserId";
				var connection = new SqlConnection(_connectionString);
				List<User> result = (List<User>)await connection.QueryAsync(query, new { UserId = userId, });
				#endregion
				return result;
			}
			catch (Exception)
			{
				throw new Exception();
			}
		}

		public Task<List<User>> GetAllUser()
		{
			throw new NotImplementedException();
		}

		public async Task<User> Update(User user)
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
					Id = user.Id,
					CreateDate = user.CreateDate,
				});
				#endregion

				#region Get Data
				query = @$"SELECT * FROM Plan WHERE Id==@Id";
			User response = (User)await connection.QueryAsync(query, new
				{
					Id = user.Id,
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
