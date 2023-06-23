using Dapper;
using MediatR;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.Contracts.Persistence.Dapper;
using ToDo.Domain.Entities.ToDo;
using ToDo.Domain.Entities.User;

namespace ToDo.Persistence.Repositories.Dapper
{
	public class ManageToDoDapper : IManageToDoDapper
	{
		//private readonly string _connectionString = @"Server=.;Initial Catalog=ToDoDB ;Integrated Security=true;";
		private readonly string _connectionString = @"Data Source =.; Initial Catalog = ToDoDB; Integrated Security = True; TrustServerCertificate=True";
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
				Plan result = (Plan)await connection.QueryAsync(query, new { Id = id, });
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
			try
			{
				#region Get Data
				string query = @"SELECT * FROM Plan WHERE UserId==@UserId";
				var connection = new SqlConnection(_connectionString);
				List<Plan> result = (List<Plan>)await connection.QueryAsync(query, new { UserId = userId, });
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
	}
}
