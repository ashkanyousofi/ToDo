using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Application.DTOs.ToDo.Validators
{
	public class IPlanDtoValidator : AbstractValidator<IPlanDto>
	{
		public IPlanDtoValidator()
		{
			RuleFor(p => p.Title).NotEmpty().WithMessage("{PropertyTitle} is required.")
			.GreaterThan("").LessThan("50")
			.NotNull().MaximumLength(30);
		}
	}
}

