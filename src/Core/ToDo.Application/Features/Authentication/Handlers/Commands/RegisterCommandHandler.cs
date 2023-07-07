
namespace ToDo.Application.Features.Authentication.Handlers.Commands
{
	public class RegisterCommandHandler : IRequestHandler<RegisterCommand, GetUserDto>
	{
		private readonly IUserRepositoryDapper _userRepositoryDapper;
		private readonly IRoleRepositoryDapper _roleRepositoryDapper;
		private readonly IMapper _mapper;
        public RegisterCommandHandler(IUserRepositoryDapper userRepositoryDapper , IRoleRepositoryDapper roleRepositoryDapper, IMapper mapper)
        {
            _userRepositoryDapper=userRepositoryDapper;
			_roleRepositoryDapper =roleRepositoryDapper;
			_mapper=mapper;
        }
        public async Task<GetUserDto> Handle(RegisterCommand request, CancellationToken cancellationToken)
		{
			var result = _userRepositoryDapper.Add(_mapper.Map<User>(request.RegisterDto));
			return _mapper.Map<GetUserDto>(result);
		}
	}
}
