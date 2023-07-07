
namespace ToDo.Application.Exceptions
{
	public class ValidationException: ApplicationException
	{
		public List<string> Errors { get; set; } = new List<string>();
		public ValidationException(FluentValidation.Results.ValidationResult validationResult)
		{
            foreach (var item in validationResult.Errors)
            {
                Errors.Add(item.ErrorMessage);
            }
        }
    }
}
