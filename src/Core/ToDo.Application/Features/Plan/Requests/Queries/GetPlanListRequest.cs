using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.DTOs.ToDo;

namespace ToDo.Application.Features.Plan.Requests.Queries
{
    public class GetPlanListRequest:IRequest<List<PlanDto>>
    {
        public string Id { get; set; }
    }
}
