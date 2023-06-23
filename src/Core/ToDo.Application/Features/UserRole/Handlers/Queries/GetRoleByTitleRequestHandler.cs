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
	public class GetRoleByTitleRequestHandler : IRequestHandler<GetRoleByTitleRequest, List<GetRoleDto>>
	{
		public Task<List<GetRoleDto>> Handle(GetRoleByTitleRequest request, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}
	}
}
