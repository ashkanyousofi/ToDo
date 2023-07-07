
namespace ToDo.Application.DTOs.UserRole.Create
{
	public class DeleteRoleDtoValidator : AbstractValidator<DeleteRoleDto>
	{
		public DeleteRoleDtoValidator()
		{
			Include(new IRoleDtoValidator());
		}
	}
}
