using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.DTOs.ToDo;

namespace ToDo.Application.DTOs.UserRole.Validators
{
	public class IRoleDtoValidator : AbstractValidator<IRoleDto>
	{
		public IRoleDtoValidator()
		{
			RuleFor(p => p.Title).NotEmpty().WithMessage("{PropertyTitle} is required.")
			.GreaterThan("").LessThan("50")
			.NotNull().MaximumLength(30);
		}
	}
}
