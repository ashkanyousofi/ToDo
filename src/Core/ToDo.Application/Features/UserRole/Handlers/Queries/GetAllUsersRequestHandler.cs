
namespace ToDo.Application.Features.UserRole.Handlers.Queries
{
	public class GetAllUsersRequestHandler : IRequestHandler<GetAllUsersRequest, List<GetUserDto>>
	{
		public Task<List<GetUserDto>> Handle(GetAllUsersRequest request, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}
	}
}
