

namespace ToDo.Application.Features.Plan.Handlers.Commands
{
	public class DeletePlanCommandHandler : IRequestHandler<DeletePlanCommand, bool>
	{
		private readonly IManageToDoDapper _manageToDoDapper;
		private readonly IMapper _mapper;
        public DeletePlanCommandHandler(IManageToDoDapper manageToDoDapper,IMapper mapper)
        {
            _manageToDoDapper = manageToDoDapper;
			_mapper = mapper;
        }
        public async Task<bool> Handle(DeletePlanCommand request, CancellationToken cancellationToken)
		{
			var result = await _manageToDoDapper.Delete(_mapper.Map<ToDo.Domain.Entities.ToDo.Plan>(request.DeletePlanDto));
			return result;
		}
	}
}
