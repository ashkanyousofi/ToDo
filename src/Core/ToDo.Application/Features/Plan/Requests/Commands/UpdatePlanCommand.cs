using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.DTOs.ToDo;

namespace ToDo.Application.Features.Plan.Requests.Commands
{
    public class UpdatePlanCommand : IRequest<PlanDto>
    {
        public UpdatePlanDto UpdatePlanDto{ get; set; }
    }
}
