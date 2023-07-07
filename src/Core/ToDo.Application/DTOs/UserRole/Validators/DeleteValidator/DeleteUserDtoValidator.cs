
namespace ToDo.Application.DTOs.UserRole.Create
{
	public class DeleteUserDtoValidator : AbstractValidator<DeleteUserDto>
	{
		public DeleteUserDtoValidator()
		{
			Include(new IUserDtoValidator());
		}
	}
}
