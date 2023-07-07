
namespace ToDo.Persistence.Configurations.Entities
{
	public class UserConfiguration : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
			builder.HasData(
				new User
				{
					Id = "1",
					FirstName = "Test",
					LastName ="Test",
					Email = "Test@test.com",
					Birthday=DateTime.Now,
					PhoneNumber="09100000000",
					PhoneNumberIsActive=true,
					PlanCount=3,
					CreateDate = DateTime.Now,
					LastModify = DateTime.Now,
					IsActive = true,
					IsDelete = false,
				},
				new User
				{
					Id = "2",
					FirstName = "Test2",
					LastName = "Test2",
					Email = "Test2@test.com",
					Birthday = DateTime.Now,
					PhoneNumber = "09110000000",
					PhoneNumberIsActive = true,
					PlanCount = 0,
					CreateDate = DateTime.Now,
					LastModify = DateTime.Now,
					IsActive = true,
					IsDelete = false,
				},
				new User
				{
					Id = "3",
					FirstName = "Test3",
					LastName = "Test3",
					Email = "Test3@test.com",
					Birthday = DateTime.Now,
					PhoneNumber = "09120000000",
					PhoneNumberIsActive = true,
					PlanCount = 0,
					CreateDate = DateTime.Now,
					LastModify = DateTime.Now,
					IsActive = true,
					IsDelete = false,
				}
			);
		}
	}
}
