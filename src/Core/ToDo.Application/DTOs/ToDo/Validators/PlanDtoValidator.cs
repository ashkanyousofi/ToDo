using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Application.DTOs.ToDo.Validators
{
	public class PlanDtoValidator: AbstractValidator<PlanDto>
	{
        public PlanDtoValidator()
        {
            Include(new IPlanDtoValidator());
        }
    }
}
