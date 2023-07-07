
namespace ToDo.Application.Features.UserRole.Handlers.Queries
{
	public class GetUserRolesRequestHandler : IRequestHandler<GetUserRolesRequest, List<GetRoleDto>>
	{
		public Task<List<GetRoleDto>> Handle(GetUserRolesRequest request, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}
	}
}
