
namespace ToDo.Application.DTOs.Authentication
{
	public class RegisterDto
	{
		[Required]
        public string FirstName { get; set; }
        [Required]
		public string Email { get; set; }
		[Required]
		public string Password { get; set; }
		[Required]
		[Compare(nameof(RePassword))]
		public string RePassword { get; set; }
	}
}
