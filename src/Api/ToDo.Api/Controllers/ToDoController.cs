
namespace ToDo.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ToDoController : ControllerBase
	{
		#region Constructor
		private readonly IMediator _mediator;
		private readonly IMapper _mapper;

		public ToDoController(IMediator mediator, IMapper mapper)
		{
			_mediator = mediator;
			_mapper = mapper;
		}
		#endregion
		
		#region Get
		[HttpGet("GetPlan/{planId}")]
		public async Task<ActionResult<PlanDto>> GetPlan(string planId)
		{
			if (!ModelState.IsValid) return BadRequest(planId);
			PlanDto plan = await _mediator.Send(new GetPlanRequest() { Id = planId });
			return Ok(plan);
		}

		[HttpGet("GetPlans/{userId}")]
		public async Task<ActionResult<IEnumerable<PlanDto>>> GetPlans(string userId)
		{
			if (!ModelState.IsValid) return BadRequest(userId);
			List<PlanDto> plan = await _mediator.Send(new GetPlanListRequest() { Id = userId });
			return Ok(plan);
		}
		#endregion

		#region Post
		[HttpPost("InsertPlan")]
		public async Task<ActionResult<PlanDto>> InsertPlan([FromBody] CreatePlanDto createPlanDto)
		{
			if (!ModelState.IsValid) return BadRequest();
			var plan = await _mediator.Send(new CreatePlanCommand() { CreatePlanDto = createPlanDto });
			return Ok(plan);
		}
		#endregion

		#region Put
		[HttpPut("UpdatePlan")]
		public async Task<ActionResult<PlanDto>> GetUserPlans([FromBody] UpdatePlanDto updatePlanDto)
		{
			if (!ModelState.IsValid) return BadRequest();
			PlanDto plan = await _mediator.Send(new UpdatePlanCommand() { UpdatePlanDto = updatePlanDto });
			return Ok(plan);
		}
		#endregion

		#region Delete
		[HttpDelete("DeletePlan/{planId}")]
		public async Task<ActionResult> DeletePlan(string planId)
		{
			if (!ModelState.IsValid) return BadRequest();
			PlanDto plan = await _mediator.Send(new GetPlanRequest() { Id = planId });
			var result = await _mediator.Send(new DeletePlanCommand() { DeletePlanDto = _mapper.Map<DeletePlanDto>(plan) });
			return Ok(plan);
		}
		#endregion
	}
}
