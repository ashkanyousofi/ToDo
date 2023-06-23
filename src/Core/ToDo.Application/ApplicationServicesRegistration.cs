using MediatR;
using Microsoft.Extensions.DependencyInjection;
using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.Behaviors.Plan;
using ToDo.Application.Profiles;

namespace ToDo.Application
{
	public static class ApplicationServicesRegistration
	{
		public static void ConfigureApplicationSerivces(this IServiceCollection services)
		{
			services.AddMediatR(config => config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
			//services.AddAutoMapper(typeof(MappingProfile));
			services.AddAutoMapper(Assembly.GetExecutingAssembly());
			services.AddTransient(typeof(IPipelineBehavior<,>), typeof(PlanBehaviors<,>));
		}
	}
}
