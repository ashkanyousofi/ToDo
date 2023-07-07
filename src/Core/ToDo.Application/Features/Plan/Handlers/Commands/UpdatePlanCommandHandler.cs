
namespace ToDo.Application.Features.Plan.Handlers.Commands
{
	public class UpdatePlanCommandHandler : IRequestHandler<UpdatePlanCommand, PlanDto>
	{
		private readonly IManageToDoDapper _manageToDoDapper;
		private readonly IMapper _mapper;
        public UpdatePlanCommandHandler(IManageToDoDapper manageToDoDapper, IMapper mapper)
        {
            _manageToDoDapper= manageToDoDapper;
			_mapper= mapper;
        }
        public async Task<PlanDto> Handle(UpdatePlanCommand request, CancellationToken cancellationToken)
		{
			var result=await _manageToDoDapper.Update(_mapper.Map<ToDo.Domain.Entities.ToDo.Plan>(request.UpdatePlanDto));
			return _mapper.Map<PlanDto>(result);
		}
	}
}
