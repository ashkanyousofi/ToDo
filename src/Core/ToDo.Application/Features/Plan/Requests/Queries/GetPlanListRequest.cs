
namespace ToDo.Application.Features.Plan.Requests.Queries
{
    public class GetPlanListRequest:IRequest<List<PlanDto>>
    {
        public string Id { get; set; }
    }
}
