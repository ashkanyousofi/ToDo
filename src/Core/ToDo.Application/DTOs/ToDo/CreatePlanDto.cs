using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.DTOs.Common;

namespace ToDo.Application.DTOs.ToDo
{
	public class CreatePlanDto:BaseDto,IPlanDto
	{
        public string Title { get; set; }
    }
}
