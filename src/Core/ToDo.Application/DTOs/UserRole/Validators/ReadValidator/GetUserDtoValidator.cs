
namespace ToDo.Application.DTOs.UserRole.Create
{
	public class GetUserDtoValidator : AbstractValidator<GetUserDto>
	{
		public GetUserDtoValidator()
		{
			Include(new IUserDtoValidator());
		}
	}
}
