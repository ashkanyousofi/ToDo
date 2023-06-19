using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.Profiles;

namespace ToDo.Application
{
	public static class ApplicationServicesRegistration
	{
		public static void Configure(this IServiceCollection services)
		{
			//services.AddAutoMapper(typeof(MappingProfile));
			services.AddAutoMapper(Assembly.GetExecutingAssembly());

		}
	}
}
