using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Application.DTOs.ToDo.Validators
{
	public class CreatePlanDtoValidator : AbstractValidator<CreatePlanDto>
	{
		public CreatePlanDtoValidator()
		{
			Include(new IPlanDtoValidator());
		}
	}
}
