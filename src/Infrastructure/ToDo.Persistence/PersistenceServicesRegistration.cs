using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Persistence.Context;

namespace ToDo.Persistence
{
	public static class PersistenceServicesRegistration
	{
		public static IServiceCollection Configure(this IServiceCollection services
			, IConfiguration config)
		{
			#region Sql
			services.AddDbContext<ToDoContext>(options =>
			{
				options.UseSqlServer(config["ConnectionStrings:ConnectionString"]);
			});
			#endregion
			#region DI
			//services.AddScoped(typeof(interface<>),typeof(class<>));
			#endregion
			return services;
		}
	}
}
