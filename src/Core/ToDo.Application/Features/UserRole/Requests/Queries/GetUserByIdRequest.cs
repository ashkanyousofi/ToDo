
namespace ToDo.Application.Features.UserRole.Requests.Queries
{
	public class GetUserByIdRequest:IRequest<GetUserDto>
	{
        public string UserId { get; set; }
    }
}
