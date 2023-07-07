using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.Contracts.Infrastructure.Auth.TokenGenerator;
using ToDo.Application.Contracts.Infrastructure.Email;
using ToDo.Application.Models.Sender;
using ToDo.Infrastructure.Services.Auth.TokenGenerator;
using ToDo.Infrastructure.Services.Mail;

namespace ToDo.Infrastructure
{
	public static class InfrastructureServicesRegistration
	{
		public static IServiceCollection ConfigureInfrastructureSerivces(this IServiceCollection services
				, IConfiguration config)
		{

			#region Configuration
			services.Configure<EmailSetting>(config.GetSection("EmailSettings"));
			#endregion

			#region DI
			services.AddTransient<IEmailSender, EmailSender>();
			services.AddTransient<IJwt, Jwt>();
			#endregion

			return services;
		}
	}
}
