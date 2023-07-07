
namespace ToDo.Application.DTOs.UserRole.Create
{
	public class CreateUserDtoValidator : AbstractValidator<DeleteUserDto>
	{
		public CreateUserDtoValidator()
		{
			Include(new IUserDtoValidator());
		}
	}
}
