using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Entities.ToDo;
using ToDo.Domain.Entities.User;

namespace ToDo.Persistence.Configurations.Entities
{
	public class UserRolesConfiguration : IEntityTypeConfiguration<UserRoles>
	{
		public void Configure(EntityTypeBuilder<UserRoles> builder)
		{
			builder.HasData(
				new UserRoles
				{
					Id = "1",
					CreateDate = DateTime.Now,
					LastModify = DateTime.Now,
					IsActive = true,
					IsDelete = false,
					UserId = "1",
					RoleId = "1",
				},
				new UserRoles
				{
					Id = "1",
					CreateDate = DateTime.Now,
					LastModify = DateTime.Now,
					IsActive = true,
					IsDelete = false,
					UserId = "1",
					RoleId = "2",
				},
				new UserRoles
				{
					Id = "1",
					CreateDate = DateTime.Now,
					LastModify = DateTime.Now,
					IsActive = true,
					IsDelete = false,
					UserId = "1",
					RoleId = "3",
				}
			);
		}
	}
}
