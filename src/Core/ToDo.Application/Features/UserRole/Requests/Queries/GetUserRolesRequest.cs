using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.DTOs.UserRole.Create;

namespace ToDo.Application.Features.UserRole.Requests.Queries
{
	public class GetUserRolesRequest:IRequest<List<GetRoleDto>>
	{
        public string UserId { get; set; }
    }
}
