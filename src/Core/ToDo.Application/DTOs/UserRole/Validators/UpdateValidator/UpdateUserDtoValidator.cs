using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.DTOs.ToDo.Validators;
using ToDo.Application.DTOs.ToDo;
using ToDo.Application.DTOs.UserRole.Validators;

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
