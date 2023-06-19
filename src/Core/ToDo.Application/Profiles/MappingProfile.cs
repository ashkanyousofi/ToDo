using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.DTOs.ToDo;
using ToDo.Domain.Entities.ToDo;

namespace ToDo.Application.Profiles
{
	public class MappingProfile:Profile
	{
        public MappingProfile()
        {
            CreateMap<Plan,PlanDto>().ReverseMap();
        }
    }
}
