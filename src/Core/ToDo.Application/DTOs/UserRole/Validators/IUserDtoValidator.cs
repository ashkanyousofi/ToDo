using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.DTOs.ToDo;

namespace ToDo.Application.DTOs.UserRole.Validators
{
	public class IUserDtoValidator : AbstractValidator<IUserDto>
	{
		public IUserDtoValidator()
		{
			RuleFor(p => p.FirstName).NotEmpty().WithMessage("{PropertyTitle} is required.")
			.GreaterThan("").LessThan("50")
			.NotNull().MaximumLength(30);
		}
	}
}
