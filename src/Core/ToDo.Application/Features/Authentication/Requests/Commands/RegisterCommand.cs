
namespace ToDo.Application.Features.Authentication.Requests.Commands
{
	public class RegisterCommand:IRequest<GetUserDto>
	{
        public RegisterDto RegisterDto{ get; set; }
    }
}
