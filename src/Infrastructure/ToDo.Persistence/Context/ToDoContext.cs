
namespace ToDo.Persistence.Context
{
	public class ToDoContext : DbContext
	{
		public ToDoContext(DbContextOptions<ToDoContext> options) : base(options)
		{

		}

		#region Entities
		public DbSet<Plan> Plans { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Role> Roles { get; set; }
		public DbSet<UserRoles> UserRoles { get; set; }
		#endregion

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
			modelBuilder.Entity<UserRoles>().HasKey(k => new { k.UserId, k.RoleId });
			base.OnModelCreating(modelBuilder);
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
		}

		#region Save
		public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
		{
			foreach (var entry in ChangeTracker.Entries<BaseEntity>())
			{
				switch (entry.State)
				{
					case EntityState.Added:
						entry.Entity.CreateDate = DateTime.Now;
						break;
					case EntityState.Modified:
						entry.Entity.LastModify = DateTime.Now;
						break;
				}
			}
			return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
		}
		public override int SaveChanges()
		{
			foreach (var entry in ChangeTracker.Entries<BaseEntity>())
			{
				switch (entry.State)
				{
					case EntityState.Added:
						entry.Entity.CreateDate = DateTime.Now;
						break;
					case EntityState.Modified:
						entry.Entity.LastModify = DateTime.Now;
						break;
				}
			}
			return base.SaveChanges();
		}
		#endregion
	}
}
