using AutoMapper;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ToDo.Application.Contracts.Persistence.Dapper;
using ToDo.Application.DTOs.ToDo;
using ToDo.Application.Features.Plan.Handlers.Queries;
using ToDo.Application.Features.Plan.Requests.Queries;
using ToDo.Application.Profiles;
using ToDo.UnitTest.Mocks;

namespace ToDo.UnitTest.Tests.Plan.Queries
{
    public class GetPlanListRequestHandlerTests
	{
  //      IMapper _mapper;
  //      Mock<IManageToDoDapper> _mockRepository;
  //      public GetPlanListRequestHandlerTests()
  //      {
		//	_mockRepository = MockPlanRepository.GetPlanRepository();
		//	#region ConfigMapper
		//	var mapperConfig = new MapperConfiguration(m =>
		//	{
		//		m.AddProfile<MappingProfile>();

		//	});
		//	_mapper = mapperConfig.CreateMapper();
		//	#endregion
		//}
		//[Fact]
		//public async Task GetPlanListTest()
		//{
		//	var handler = new GetPlanListRequestHandler(_mockRepository.Object,_mapper);
		//	var result = await handler.Handle(new GetPlanListRequest(),CancellationToken.None);
		//	result.ShouldBeOfType<List<PlanDto>>();
		//	result.Count.ShouldBe(3);
		//}
	}
}
