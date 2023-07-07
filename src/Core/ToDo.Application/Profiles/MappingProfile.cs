
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
