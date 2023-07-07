
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
