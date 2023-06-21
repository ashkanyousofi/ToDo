using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.Contracts.Infrastructure.Email;
using ToDo.Application.Models.Sender;
using ToDo.Infrastructure.Services.Mail;

namespace ToDo.Infrastructure
{
	public static class InfrastructureServicesRegistration
	{
		public static IServiceCollection Configure(this IServiceCollection services
				, IConfiguration config)
		{
			services.Configure<EmailSetting>(config.GetSection("EmailSettings"));
			services.AddTransient<IEmailSender,EmailSender>();


			return services;
		}
	}
}
