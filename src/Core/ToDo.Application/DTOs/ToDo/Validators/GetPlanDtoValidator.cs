using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.DTOs.ToDo.Validators;

namespace ToDo.Application.DTOs.ToDo
{
	public class GetPlanDtoValidator : AbstractValidator<PlanDto>
	{
		public GetPlanDtoValidator()
		{
			Include(new IPlanDtoValidator());
		}
	}
}
