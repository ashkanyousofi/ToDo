using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ToDo.Application.DTOs.ToDo;
using ToDo.Application.Features.Plan.Requests.Queries;
using ToDo.Domain.Entities.ToDo;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDo.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ToDoController : ControllerBase
	{
		private readonly IMediator _mediator;

		public ToDoController(IMediator mediator)
        {
			_mediator = mediator;
		}
        // GET: api/<ToDoController>
        [HttpGet]
		public async Task<ActionResult<IEnumerable<PlanDto>>> Get(string userId)
		{
			var plan = await _mediator.Send(new GetPlanListRequest());
			return plan;
		}

		// GET api/<ToDoController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<ToDoController>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/<ToDoController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<ToDoController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
