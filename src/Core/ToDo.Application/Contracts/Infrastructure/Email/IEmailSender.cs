
namespace ToDo.Application.Contracts.Infrastructure.Email
{
	public interface IEmailSender
	{
		Task<bool> SendEmail(EmailModel email);
	}
}
