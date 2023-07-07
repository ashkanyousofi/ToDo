
namespace ToDo.Application.Features.UserRole.Requests.Queries
{
	public class GetRoleByTitleRequest:IRequest<List<GetRoleDto>>
	{
        public string Title { get; set; }
    }
}
