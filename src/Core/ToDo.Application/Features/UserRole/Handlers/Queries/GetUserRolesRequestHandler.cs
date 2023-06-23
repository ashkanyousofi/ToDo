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
	public class GetUserRolesRequestHandler : IRequestHandler<GetUserRolesRequest, List<GetRoleDto>>
	{
		public Task<List<GetRoleDto>> Handle(GetUserRolesRequest request, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}
	}
}
