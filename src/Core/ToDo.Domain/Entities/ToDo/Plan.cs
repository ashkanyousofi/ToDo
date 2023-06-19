using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Entities.Common;

namespace ToDo.Domain.Entities.ToDo
{
	public class Plan:BaseEntity
	{
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
