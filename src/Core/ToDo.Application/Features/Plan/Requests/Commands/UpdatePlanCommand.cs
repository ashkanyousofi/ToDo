
namespace ToDo.Application.Features.Plan.Requests.Commands
{
    public class UpdatePlanCommand : IRequest<PlanDto>
    {
        public UpdatePlanDto UpdatePlanDto{ get; set; }
    }
}
