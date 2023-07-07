
namespace ToDo.Application.DTOs.UserRole.Create
{
	public class GetUserDto : BaseEntity, IUserDto
	{
		public string FirstName { get; set; }
		public string Title { get; set; }
		public string LastName { get; set; }
		public string? PhoneNumber { get; set; }
		public string Email { get; set; }
		public DateTime? Birthday { get; set; }
		public bool PhoneNumberIsActive { get; set; }
		public long PlanCount { get; set; }
	}
}
