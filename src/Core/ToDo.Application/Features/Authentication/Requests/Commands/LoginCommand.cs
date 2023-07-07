
namespace ToDo.Application.Features.Authentication.Requests.Commands
{
	public class LoginCommand:IRequest<string>
	{
        public LoginDto LoginDto{ get; set; }
    }
}
