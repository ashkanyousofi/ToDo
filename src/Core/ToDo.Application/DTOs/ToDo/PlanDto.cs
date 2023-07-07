
namespace ToDo.Application.DTOs.ToDo
{
	public class PlanDto : BaseDto, IPlanDto
	{
		public string Title { get; set; } = string.Empty;
		public DateTime Time { get; set; } = DateTime.Now;
		public string? Description { get; set; } = string.Empty;
		public bool IsNotification { get; set; } = true;
		public string UserId { get; set; }
	}
}
