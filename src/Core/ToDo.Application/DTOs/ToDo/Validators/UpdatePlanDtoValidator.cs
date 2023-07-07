
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
