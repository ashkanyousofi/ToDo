﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.DTOs.Common;
using ToDo.Domain.Entities.Common;

namespace ToDo.Application.DTOs.ToDo
{
	public class DeletePlanDto:BaseDto,IPlanDto
	{
		public string Title { get; set; } = string.Empty;
		public DateTime Time { get; set; } = DateTime.Now;
		public string? Description { get; set; } = string.Empty;
		public bool IsNotification { get; set; } = true;
		public string UserId { get; set; }
	}
}