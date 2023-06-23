using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.DTOs.UserRole.Create;
using ToDo.Application.Features.UserRole.Requests.Queries;

namespace ToDo.Application.Features.UserRole.Handlers.Queries
{
	public class GetUserByIdRequestHandler : IRequestHandler<GetUserByIdRequest, GetUserDto>
	{
		public Task<GetUserDto> Handle(GetUserByIdRequest request, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}
	}
}
