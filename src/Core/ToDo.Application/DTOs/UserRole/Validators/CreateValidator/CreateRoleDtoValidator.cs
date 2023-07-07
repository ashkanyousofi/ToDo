
namespace ToDo.Application.DTOs.UserRole.Create
{
	public class CreateRoleDtoValidator: AbstractValidator<CreateRoleDto>
	{
		public CreateRoleDtoValidator()
		{
			Include(new IRoleDtoValidator());
		}
	}
}
