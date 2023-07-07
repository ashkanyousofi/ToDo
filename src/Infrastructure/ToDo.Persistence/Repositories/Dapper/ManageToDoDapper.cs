
namespace ToDo.Persistence.Repositories.Dapper
{
	public class ManageToDoDapper : IManageToDoDapper
	{
		private readonly string _connectionString = @"Server =.; User ID = .;Initial Catalog=ToDoDB; Integrated Security = True;TrustServerCertificate=True";
		//private readonly string _connectionString = @"Data Source =.; Initial Catalog = ToDoDB; Integrated Security = True; TrustServerCertificate=True";
		public async Task<Plan> Add(Plan plan)
		{
			try
			{
				#region Insert Data
				string query = @"INSERT INTO Plan (Id,Time,Title,IsNotification,UserId,Description,CreateDate) Values
					(@Id,@Time,@Title,@IsNotification,@UserId,@Description,@CreateDate)";
				var connection = new SqlConnection(_connectionString);

				var result = await connection.ExecuteAsync(query, new
				{
					plan.Id,
					plan.Time,
					plan.Title,
					plan.IsNotification,
					plan.UserId,
					plan.Description,
					plan.CreateDate,
				});
				#endregion

				#region Get Data
				query = @$"SELECT * FROM Plan WHERE Id=@Id";
				Plan response = (Plan)await connection.QueryAsync(query, new
				{
					Id = plan.Id,
				});
				#endregion
				return response;
			}
			catch (Exception)
			{
				throw new Exception();
			}
		}

		public async Task<bool> Delete(Plan plan)
		{
			try
			{
				#region Get Data
				string query = @"DELETE FROM Plan WHERE Id=@Id";
				var connection = new SqlConnection(_connectionString);
				var result = await connection.ExecuteAsync(query, new { Id = plan.Id });
				#endregion
				return result == 1 ? true : false;
			}
			catch (Exception)
			{
				throw new Exception();
			}
		}

		public async Task<List<Plan>> Get(Func<Plan, bool> operation)
		{
			try
			{
				#region Get Data
				string query = @"SELECT * FROM Plan";
				var connection = new SqlConnection(_connectionString);
				List<Plan> result = (List<Plan>)await connection.QueryAsync(query);
				#endregion
				return result.Where(operation).ToList();
			}
			catch (Exception)
			{
				throw new Exception();
			}
		}

		public async Task<Plan> Get(string id)
		{
			try
			{
				#region Get Data
				string query = @"SELECT * FROM Plan WHERE Id==@Id";
				var connection = new SqlConnection(_connectionString);
				connection.Open();

				Plan result = (Plan)await connection.QueryAsync(query, new { Id = id, });
				connection.Close();
				#endregion
				return result;
			}
			catch (Exception)
			{
				throw new Exception();
			}
		}

		public async Task<List<Plan>> GetAllPlansByUserId(string userId)
		{
			//string query = "SELECT * FROM Plans where UserId==@UserId";
			////string query = @"SELECT * FROM Plan";
			//var connection = new SqlConnection(_connectionString);
			//await connection.OpenAsync();
			//var result = (List<Plan>)await connection.QueryAsync(query, new { UserId = userId });
			try
			{
				#region Get Data
				string query = "SELECT * FROM Plans";
				var connection = new SqlConnection(_connectionString);
				await connection.OpenAsync();
				var result = connection.Query<Plan>(query).Where(plan => plan.UserId == userId).ToList();
				await connection.CloseAsync();
				#endregion
				return result;
			}
			catch (Exception)
			{
				throw new Exception();
			}
		}

		public async Task<Plan> Update(Plan plan)
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
					Id = plan.Id,
					Time = plan.Time,
					Title = plan.Title,
					IsNotification = plan.IsNotification,
					UserId = plan.UserId,
					Description = plan.Description,
					CreateDate = plan.CreateDate,
				});
				#endregion

				#region Get Data
				query = @$"SELECT * FROM Plan WHERE Id==@Id";
				var response = await connection.QuerySingleOrDefaultAsync<Plan>(query, new
				{
					Id = plan.Id,
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
