using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Entities.Common;

namespace ToDo.Domain.Entities.ToDo
{
	public class Plan:BaseEntity
	{
        public Plan()
        {
            
        }
        public string Title { get; set; } = string.Empty;
        public DateTime Time { get; set; }= DateTime.Now;
        public string? Description { get; set; } = string.Empty;
        public bool IsNotification { get; set; } = true;
        public string UserId { get; set; }

        #region Relations
        [ForeignKey(nameof(Id))]
        public User.User User { get; set; }
        #endregion
    }
}
