
namespace ToDo.Application.Features.UserRole.Handlers.Queries
{
	public class GetRoleByTitleRequestHandler : IRequestHandler<GetRoleByTitleRequest, List<GetRoleDto>>
	{
		public Task<List<GetRoleDto>> Handle(GetRoleByTitleRequest request, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}
	}
}
