﻿
namespace ToDo.Application.Features.Plan.Handlers.Queries
{
    public class GetPlanListRequestHandler :
		IRequestHandler<GetPlanListRequest, List<PlanDto>>
	{
		private readonly IManageToDoDapper _manageToDo;
		private readonly IMapper _mapper;
		public GetPlanListRequestHandler(IManageToDoDapper manageToDo, IMapper mapper)
		{
			_manageToDo = manageToDo;
			_mapper = mapper;
		}

		public async Task<List<PlanDto>> Handle(GetPlanListRequest request, CancellationToken cancellationToken)
		{
			var plans = await _manageToDo.GetAllPlansByUserId(request.Id);
			return _mapper.Map<List<PlanDto>>(plans);
		}
	}
}
