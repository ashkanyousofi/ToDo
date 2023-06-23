using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Entities.Common;

namespace ToDo.Application.DTOs.UserRole.Create
{
	public class GetRoleDto : BaseEntity, IRoleDto
	{
		public string Title { get; set; }
		public string? Description { get; set; } = string.Empty;
		public string? ParentId { get; set; }
	}
}
