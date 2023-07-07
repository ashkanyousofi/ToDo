
namespace ToDo.Persistence.Configurations.Entities
{
	public class PlanConfiguration : IEntityTypeConfiguration<Plan>
	{
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ToDo.Domain.Entities.ToDo.Plan> builder)
		{
			builder.HasData(new Plan
			{
				Id = "1",
				CreateDate = DateTime.Now,
				LastModify = DateTime.Now,
				Description = "",
				IsActive = true,
				IsDelete = false,
				IsNotification = true,
				Time = DateTime.Now,
				Title = "School",
				UserId = "1"
			}, new Plan
			{
				Id = "2",
				CreateDate = DateTime.Now,
				LastModify = DateTime.Now,
				Description = "",
				IsActive = true,
				IsDelete = false,
				IsNotification = true,
				Time = DateTime.Now,
				Title = "School2",
				UserId = "1"
			}, new Plan
			{
				Id = "3",
				CreateDate = DateTime.Now,
				LastModify = DateTime.Now,
				Description = "",
				IsActive = true,
				IsDelete = false,
				IsNotification = true,
				Time = DateTime.Now,
				Title = "School3",
				UserId = "1"
			});
		}
	}
}
