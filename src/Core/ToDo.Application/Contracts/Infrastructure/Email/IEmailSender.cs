using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.Models.Sender;

namespace ToDo.Application.Contracts.Infrastructure.Email
{
	public interface IEmailSender
	{
		Task<bool> SendEmail(EmailModel email);
	}
}
