using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.DTOs.ToDo;
using ToDo.Application.Responses;

namespace ToDo.Application.Features.Plan.Requests.Commands
{
	public class CreatePlanCommand:IRequest<BaseCommandResponse>
	{
        public CreatePlanDto CreatePlanDto{ get; set; }
    }
}
