using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.DTOs.UserRole.Create;
using ToDo.Application.Features.UserRole.Requests.Queries;
using ToDo.Domain.Entities.User;

namespace ToDo.Application.Features.UserRole.Handlers.Queries
{
	public class GetAllUsersRequestHandler : IRequestHandler<GetAllUsersRequest, List<GetUserDto>>
	{
		public Task<List<GetUserDto>> Handle(GetAllUsersRequest request, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}
	}
}
