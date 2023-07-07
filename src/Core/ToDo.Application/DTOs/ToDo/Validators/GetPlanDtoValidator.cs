
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
