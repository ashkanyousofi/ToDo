
namespace ToDo.Application.DTOs.UserRole.Create
{
	public class UpdateUserDtoValidator : AbstractValidator<UpdateUserDto>
	{
		public UpdateUserDtoValidator()
		{
			Include(new IUserDtoValidator());
		}
	}
}
