
namespace ToDo.Application.DTOs.ToDo
{
	public class DeletePlanDtoValidator : AbstractValidator<PlanDto>
	{
		public DeletePlanDtoValidator()
		{
			Include(new IPlanDtoValidator());
		}
	}
}
