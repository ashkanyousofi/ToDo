using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Entities.Common;
using ToDo.Domain.Entities.ToDo;

namespace ToDo.Domain.Entities.User
{
	public class User : BaseEntity
	{
		public User()
		{

		}
		public string FirstName { get; set; } = string.Empty;
		public string LastName { get; set; } = string.Empty;
		public string? PhoneNumber { get; set; } = string.Empty;
		[Required]
		public string Password { get; set; } = string.Empty;
		public string Email { get; set; } = string.Empty;
		public DateTime? Birthday { get; set; }
		public bool PhoneNumberIsActive { get; set; } = false;
		public long PlanCount { get; set; } = 0;

		#region Relations
		public List<UserRoles> UserRoles { get; set; }
		public List<Plan> Plans { get; set; }
		#endregion
	}
}
