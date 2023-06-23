using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.DTOs.UserRole.Validators;

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
