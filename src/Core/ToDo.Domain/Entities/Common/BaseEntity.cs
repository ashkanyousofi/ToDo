using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Domain.Entities.Common
{
	public class BaseEntity
	{
        public BaseEntity()
        {
            
        }
        public string Id { get; set; }=Guid.NewGuid().ToString();
        public DateTime CreateDate { get; set; }= DateTime.Now;
        public DateTime LastModify { get; set; } = DateTime.Now;
        public bool IsDelete { get; set; } = false;
        public bool IsActive { get; set; } = false;
    }
}
