using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.Contracts.Persistence.Dapper;
using ToDo.Application.DTOs.ToDo;
using ToDo.Application.Features.Plan.Requests.Commands;
using ToDo.Domain.Entities.ToDo;

namespace ToDo.Application.Features.Plan.Handlers.Commands
{
	public class DeletePlanCommandHandler : IRequestHandler<DeletePlanCommand, bool>
	{
		private readonly IManageToDoDapper _manageToDoDapper;
		private readonly IMapper _mapper;
        public DeletePlanCommandHandler(IManageToDoDapper manageToDoDapper,IMapper mapper)
        {
            _manageToDoDapper = manageToDoDapper;
			_mapper = mapper;
        }
        public async Task<bool> Handle(DeletePlanCommand request, CancellationToken cancellationToken)
		{
			var result = await _manageToDoDapper.Delete(_mapper.Map<ToDo.Domain.Entities.ToDo.Plan>(request.DeletePlanDto));
			return result;
		}
	}
}
