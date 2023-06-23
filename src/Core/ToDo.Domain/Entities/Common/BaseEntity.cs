using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Key]
        public string Id { get; set; }=Guid.NewGuid().ToString();
        [Required]
        public DateTime CreateDate { get; set; }= DateTime.Now;
        [Required]
        public DateTime LastModify { get; set; } = DateTime.Now;
        public bool IsDelete { get; set; } = false;
        public bool IsActive { get; set; } = false;
    }
}
