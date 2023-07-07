
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

