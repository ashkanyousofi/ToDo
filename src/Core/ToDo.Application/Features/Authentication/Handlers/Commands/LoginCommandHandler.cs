

namespace ToDo.Application.Features.Authentication.Handlers.Commands
{
	public class LoginCommandHandler : IRequestHandler<LoginCommand, string>
	{
		private readonly IManageToDoDapper _manageToDo;
		private readonly IJwt _jwt;
		private readonly IMapper _mapper;

		public LoginCommandHandler(IManageToDoDapper manageToDo, IMapper mapper)
		{
			_manageToDo = manageToDo;
			_mapper = mapper;
		}

		public Task<string> Handle(LoginCommand request, CancellationToken cancellationToken)
		{
			var result = _jwt.GenerateToken(request.LoginDto);
			return result;
		}
	}
}
