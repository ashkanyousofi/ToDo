
namespace ToDo.Application.Features.Plan.Requests.Queries
{
	public class GetPlanRequest : IRequest<PlanDto>
	{
		public string Id { get; set; }
	}
}
