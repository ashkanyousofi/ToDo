using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Entities.Common;
using ToDo.Domain.Entities.Role;
using ToDo.Domain.Entities.ToDo;
using ToDo.Domain.Entities.User;

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
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(ToDoContext).Assembly);
			base.OnModelCreating(modelBuilder);
		}

		public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
		{
			//foreach (var entry in ChangeTracker.Entries<BaseEntity>())
			//{
			//	switch (entry.State)
			//	{
			//		case EntityState.Added:
			//			entry.Entity.CreateDate = DateTime.Now;
			//			break;
			//		case EntityState.Modified:
			//			entry.Entity.ModifiedDate = DateTime.Now;
			//			break;
			//	}
			//}
			return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
		}
		public override int SaveChanges()
		{
			return base.SaveChanges();
		}
	}
}
