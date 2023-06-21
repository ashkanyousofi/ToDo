using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Entities.Common;
using ToDo.Domain.Entities.Role;

namespace ToDo.Domain.Entities.User
{
	public class UserRoles : BaseEntity
	{
        public UserRoles()
        {
            
        }
        public string UserId{ get; set; }
        public string RoleId { get; set; }

        #region Relations
        [ForeignKey(nameof(Id))]
        public User User { get; set; }
        [ForeignKey(nameof(Id))]
        public Role.Role Role { get; set; }
		#endregion
	}
}
