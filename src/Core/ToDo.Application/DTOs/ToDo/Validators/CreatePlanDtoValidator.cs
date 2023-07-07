
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
