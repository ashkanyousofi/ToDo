
namespace ToDo.Application.Features.UserRole.Handlers.Queries
{
	public class GetUserByIdRequestHandler : IRequestHandler<GetUserByIdRequest, GetUserDto>
	{
		public Task<GetUserDto> Handle(GetUserByIdRequest request, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}
	}
}
