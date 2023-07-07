
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
