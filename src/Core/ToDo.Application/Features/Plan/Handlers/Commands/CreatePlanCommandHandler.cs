using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.Features.Plan.Requests.Commands;
using ToDo.Application.Persistence.Contracts;

namespace ToDo.Application.Features.Plan.Handlers.Commands
{
	public class CreatePlanCommandHandler :
		IRequestHandler<CreatePlanCommand, string>
	{
		private readonly IManageToDo _manageToDo;
		private readonly IMapper _mapper;

        public CreatePlanCommandHandler(IManageToDo manageToDo,IMapper mapper)
        {
			_manageToDo = manageToDo;
			_mapper = mapper;
        }
        public Task<string> Handle(CreatePlanCommand request, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}
	}
}
