using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.Contracts.Persistence;
using ToDo.Application.Contracts.Persistence.Dapper;
using ToDo.Persistence.Context;
using ToDo.Persistence.Repositories;
using ToDo.Persistence.Repositories.Dapper;

namespace ToDo.Persistence
{
    public static class PersistenceServicesRegistration
	{
		public static IServiceCollection ConfigurePersistenceSerivces(this IServiceCollection services
			, IConfiguration config)
		{

			#region Sql
			services.AddDbContext<ToDoContext>(options => options.UseSqlServer(config.GetConnectionString("ConnectionString")), ServiceLifetime.Transient);
			#endregion

			#region DI
			services.AddScoped<IManageToDoDapper, ManageToDoDapper>();
			services.AddScoped<IUserRepositoryDapper, UserRepositoryDapper>();
			services.AddScoped<IRoleRepositoryDapper, RoleRepositoryDapper>();
			services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
			#endregion

			return services;
		}
	}
}
