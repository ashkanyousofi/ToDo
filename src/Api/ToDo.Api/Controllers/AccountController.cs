
namespace ToDo.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AccountController : ControllerBase
	{
		#region Constructor
		private readonly IMediator _mediator;
		private readonly IMapper _mapper;
		public AccountController(IMediator mediator, IMapper mapper)
		{
			_mediator = mediator;
			_mapper = mapper;
		}
		#endregion

		//#region Get
		//[HttpGet("GetPlan/{planId}")]
		//public async Task<ActionResult<PlanDto>> GetPlan(string planId)
		//{
		//	if (!ModelState.IsValid) return BadRequest(planId);
		//	PlanDto plan = await _mediator.Send(new GetPlanRequest() { Id = planId });
		//	return Ok(plan);
		//}

		//[HttpGet("GetPlans/{userId}")]
		//public async Task<ActionResult<IEnumerable<PlanDto>>> GetPlans(string userId)
		//{
		//	if (!ModelState.IsValid) return BadRequest(userId);
		//	List<PlanDto> plan = await _mediator.Send(new GetPlanListRequest() { Id = userId });
		//	return Ok(plan);
		//}
		//#endregion

		//#region Post
		//[HttpGet("GetPlan/{planId}")]
		//public async Task<ActionResult<PlanDto>> GetPlan(string planId)
		//{
		//	if (!ModelState.IsValid) return BadRequest(planId);
		//	PlanDto plan = await _mediator.Send(new GetPlanRequest() { Id = planId });
		//	return Ok(plan);
		//}

		//[HttpGet("GetPlans/{userId}")]
		//public async Task<ActionResult<IEnumerable<PlanDto>>> GetPlans(string userId)
		//{
		//	if (!ModelState.IsValid) return BadRequest(userId);
		//	List<PlanDto> plan = await _mediator.Send(new GetPlanListRequest() { Id = userId });
		//	return Ok(plan);
		//}
		//#endregion

		//#region Put
		//[HttpGet("GetPlan/{planId}")]
		//public async Task<ActionResult<PlanDto>> GetPlan(string planId)
		//{
		//	if (!ModelState.IsValid) return BadRequest(planId);
		//	PlanDto plan = await _mediator.Send(new GetPlanRequest() { Id = planId });
		//	return Ok(plan);
		//}

		//[HttpGet("GetPlans/{userId}")]
		//public async Task<ActionResult<IEnumerable<PlanDto>>> GetPlans(string userId)
		//{
		//	if (!ModelState.IsValid) return BadRequest(userId);
		//	List<PlanDto> plan = await _mediator.Send(new GetPlanListRequest() { Id = userId });
		//	return Ok(plan);
		//}
		//#endregion

		//#region Delete
		//[HttpGet("GetPlan/{planId}")]
		//public async Task<ActionResult<PlanDto>> GetPlan(string planId)
		//{
		//	if (!ModelState.IsValid) return BadRequest(planId);
		//	PlanDto plan = await _mediator.Send(new GetPlanRequest() { Id = planId });
		//	return Ok(plan);
		//}

		//[HttpGet("GetPlans/{userId}")]
		//public async Task<ActionResult<IEnumerable<PlanDto>>> GetPlans(string userId)
		//{
		//	if (!ModelState.IsValid) return BadRequest(userId);
		//	List<PlanDto> plan = await _mediator.Send(new GetPlanListRequest() { Id = userId });
		//	return Ok(plan);
		//}
		//#endregion
	}
}