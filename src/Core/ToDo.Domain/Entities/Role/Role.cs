using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Entities.Common;
using ToDo.Domain.Entities.User;

namespace ToDo.Domain.Entities.Role
{
	public class Role:BaseEntity
	{
        public Role()
        {
            
        }
        public string Title { get; set; }
        public string? Description { get; set; } = string.Empty;
        public string? ParentId { get; set; }

        #region Relations
        public List<UserRoles> UserRoles{ get; set; }
        #endregion
    }
}
