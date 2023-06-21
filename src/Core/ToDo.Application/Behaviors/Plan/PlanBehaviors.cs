using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Application.Behaviors.Plan
{
	public class PlanBehaviors<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>where TRequest:IRequest<TResponse>
	{
		public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
		{



			var response= await next();



			return response;
		}
	}
}
