﻿
namespace ToDo.Application.DTOs.UserRole.Create
{
	public class DeleteRoleDto : BaseEntity, IRoleDto
	{
		public string Title { get; set; }
		public string? Description { get; set; } = string.Empty;
		public string? ParentId { get; set; }
	}
}
