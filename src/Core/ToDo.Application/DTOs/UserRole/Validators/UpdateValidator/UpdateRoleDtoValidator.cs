﻿
namespace ToDo.Application.DTOs.UserRole.Create
{
	public class UpdateRoleDtoValidator : AbstractValidator<DeleteRoleDto>
	{
		public UpdateRoleDtoValidator()
		{
			Include(new IRoleDtoValidator());
		}
	}
}
