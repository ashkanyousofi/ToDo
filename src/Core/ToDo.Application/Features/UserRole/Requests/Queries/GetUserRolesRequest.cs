
namespace ToDo.Application.Features.UserRole.Requests.Queries
{
	public class GetUserRolesRequest:IRequest<List<GetRoleDto>>
	{
        public string UserId { get; set; }
    }
}
