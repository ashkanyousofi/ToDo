﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Domain.Entities.Common
{
	public class BaseEntity
	{
        public string Id { get; set; }=Guid.NewGuid().ToString();
    }
}
