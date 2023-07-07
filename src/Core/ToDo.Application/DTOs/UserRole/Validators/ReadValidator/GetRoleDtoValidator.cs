
namespace ToDo.Application.DTOs.UserRole.Create
{
	public class GetRoleDtoValidator : AbstractValidator<GetRoleDto>
	{
		public GetRoleDtoValidator()
		{
			Include(new IRoleDtoValidator());
		}
	}
}
