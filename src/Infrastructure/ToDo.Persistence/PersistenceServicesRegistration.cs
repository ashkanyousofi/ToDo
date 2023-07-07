
namespace ToDo.Persistence
{
    public static class PersistenceServicesRegistration
	{
		public static IServiceCollection ConfigurePersistenceSerivces(this IServiceCollection services
			, IConfiguration config)
		{

			#region Sql
			services.AddDbContext<ToDoContext>(options => options.UseSqlServer(config.GetConnectionString("ConnectionString")), ServiceLifetime.Transient);
			#endregion

			#region DI
			services.AddScoped<IManageToDoDapper, ManageToDoDapper>();
			services.AddScoped<IUserRepositoryDapper, UserRepositoryDapper>();
			services.AddScoped<IRoleRepositoryDapper, RoleRepositoryDapper>();
			services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
			#endregion

			return services;
		}
	}
}
