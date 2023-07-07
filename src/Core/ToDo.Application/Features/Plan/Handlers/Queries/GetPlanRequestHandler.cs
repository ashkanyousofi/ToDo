
namespace ToDo.Application.Features.Plan.Handlers.Queries
{
	public class GetPlanRequestHandler : IRequestHandler<GetPlanRequest, PlanDto>
	{
		private readonly IManageToDoDapper _manageToDo;
		private readonly IMapper _mapper;
		public GetPlanRequestHandler(IManageToDoDapper manageToDo, IMapper mapper)
		{
			_manageToDo = manageToDo;
			_mapper = mapper;
		}

		public async Task<PlanDto> Handle(GetPlanRequest request, CancellationToken cancellationToken)
		{
			PlanDto plan = _mapper.Map<PlanDto>(await _manageToDo.Get(request.Id));
			return plan;
		}
	}
}
