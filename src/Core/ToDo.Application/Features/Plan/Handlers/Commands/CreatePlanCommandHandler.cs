using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.DTOs.ToDo.Validators;
using ToDo.Application.Features.Plan.Requests.Commands;
using ToDo.Application.Contracts.Persistence;
using ToDo.Application.Exceptions;
using ToDo.Application.Responses;

namespace ToDo.Application.Features.Plan.Handlers.Commands
{
	public class CreatePlanCommandHandler :
		IRequestHandler<CreatePlanCommand, BaseCommandResponse>
	{
		private readonly IManageToDo _manageToDo;
		private readonly IMapper _mapper;

        public CreatePlanCommandHandler(IManageToDo manageToDo,IMapper mapper)
        {
			_manageToDo = manageToDo;
			_mapper = mapper;
        }
        public async Task<BaseCommandResponse> Handle(CreatePlanCommand request, CancellationToken cancellationToken)
		{
			#region Response
			var response = new BaseCommandResponse();
			#endregion
			#region Validation
			var validator = new CreatePlanDtoValidator();
			var validationResult = await validator.ValidateAsync(request.CreatePlanDto);

			if (validationResult.IsValid == false)
			{
				//throw new ValidationException(validationResult);
				response.Success = false;
				response.Message = "Is not valid";
				response.Errors = validationResult.Errors.Select(e => e.ErrorMessage).ToList();
			}
			#endregion
			#region Operations

			#endregion
			response.Success = false;
			response.Message = "Validation is success";
			response.Id = "";
			return response;
		}
	}
}
