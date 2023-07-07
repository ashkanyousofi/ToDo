
namespace ToDo.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthController : ControllerBase
	{
		#region Constructor
		private readonly IMediator _mediator;
		private readonly IMapper _mapper;
		public AuthController(IMediator mediator, IMapper mapper)
		{
			_mediator = mediator;
			_mapper = mapper;
		}
		#endregion

		#region Auth
		[AllowAnonymous]
		[HttpPost("Login")]
		public async Task<ActionResult<string>> Login(LoginDto loginDto)
		{
			var result = await _mediator.Send(new LoginCommand() { LoginDto = loginDto });
			return Ok(result);
		}

		[AllowAnonymous]
		[HttpPost("Register")]
		public async Task<ActionResult<GetUserDto>> Register(RegisterDto registerDto)
		{
			var result = await _mediator.Send(new RegisterCommand() { RegisterDto = registerDto });
			return Ok(result);
		}
		#endregion
	}
}
