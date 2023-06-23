using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.DTOs.ToDo.Validators;

namespace ToDo.Application.DTOs.ToDo
{
	public class UpdatePlanDtoValidator : AbstractValidator<PlanDto>
	{
		public UpdatePlanDtoValidator()
		{
			Include(new IPlanDtoValidator());
		}
	}
}
