
namespace ToDo.Application.Features.Plan.Requests.Commands
{
    public class DeletePlanCommand : IRequest<bool>
    {
        public DeletePlanDto DeletePlanDto { get; set; }
    }
}
