using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Entities.Role;
using ToDo.Domain.Entities.ToDo;
using ToDo.Domain.Entities.User;

namespace ToDo.Persistence.Configurations.Entities
{
	public class RoleConfiguration : IEntityTypeConfiguration<Role>
	{
		public void Configure(EntityTypeBuilder<Role> builder)
		{
			builder.HasData(
				new Role
				{
					Id = "1",
					CreateDate = DateTime.Now,
					LastModify = DateTime.Now,
					Description = "",
					IsActive = true,
					IsDelete = false,
					Title = "Creator",
				},
				new Role
				{
					Id = "2",
					CreateDate = DateTime.Now,
					LastModify = DateTime.Now,
					Description = "",
					IsActive = true,
					IsDelete = false,
					Title = "Admin",
				},
				new Role
				{
					Id = "3",
					CreateDate = DateTime.Now,
					LastModify = DateTime.Now,
					Description = "",
					IsActive = true,
					IsDelete = false,
					Title = "User",
				}
			);
		}
	}
}
