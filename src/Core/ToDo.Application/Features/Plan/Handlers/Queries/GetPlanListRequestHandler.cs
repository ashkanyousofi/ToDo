using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.DTOs.ToDo;
using ToDo.Application.Features.Plan.Requests.Queries;
using ToDo.Application.Contracts.Persistence.Dapper;

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
			var plans = await _manageToDo.Get(request.Id);
			return _mapper.Map<List<PlanDto>>(plans);
		}
	}
}
