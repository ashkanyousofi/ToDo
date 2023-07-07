
namespace ToDo.Application.Features.Plan.Requests.Commands
{
	public class CreatePlanCommand:IRequest<BaseCommandResponse>
	{
        public CreatePlanDto CreatePlanDto{ get; set; }
    }
}
