
namespace ToDo.Application
{
	public static class ApplicationServicesRegistration
	{
		public static void ConfigureApplicationSerivces(this IServiceCollection services)
		{
			services.AddMediatR(config => config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
			//services.AddAutoMapper(typeof(MappingProfile));
			services.AddAutoMapper(Assembly.GetExecutingAssembly());
			services.AddTransient(typeof(IPipelineBehavior<,>), typeof(PlanBehaviors<,>));
		}
	}
}
