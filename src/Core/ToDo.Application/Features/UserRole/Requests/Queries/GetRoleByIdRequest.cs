
namespace ToDo.Application.Features.UserRole.Requests.Queries
{
	public class GetRoleByIdRequest:IRequest<GetRoleDto>
	{
        public string RoleId { get; set; }
    }
}
