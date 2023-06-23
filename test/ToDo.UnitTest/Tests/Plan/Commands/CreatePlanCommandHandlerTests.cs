using AutoMapper;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.Contracts.Persistence.Dapper;
using ToDo.Application.DTOs.ToDo;
using ToDo.Application.Features.Plan.Handlers.Commands;
using ToDo.Application.Features.Plan.Handlers.Queries;
using ToDo.Application.Features.Plan.Requests.Commands;
using ToDo.Application.Features.Plan.Requests.Queries;
using ToDo.Application.Profiles;
using ToDo.UnitTest.Mocks;

namespace ToDo.UnitTest.Tests.Plan.Commands
{
    public class CreatePlanCommandHandlerTests
	{
		IMapper _mapper;
		Mock<IManageToDoDapper> _mockRepository;
		CreatePlanDto _createPlanlanDto;
		public CreatePlanCommandHandlerTests()
		{
			_mockRepository = MockPlanRepository.GetPlanRepository();
			#region ConfigMapper
			var mapperConfig = new MapperConfiguration(m =>
			{
				m.AddProfile<MappingProfile>();

			});
			_mapper = mapperConfig.CreateMapper();
			#endregion
			_createPlanlanDto = new CreatePlanDto()
			{
				
			};
		}
		[Fact]
		public async Task CreatePlanTest()
		{
			var handler = new CreatePlanCommandHandler(_mockRepository.Object, _mapper);
			var result = await handler.Handle(new CreatePlanCommand()
			{
				CreatePlanDto = _createPlanlanDto
			}, CancellationToken.None); ;

			result.ShouldBeOfType<string>();
			var plan = await _mockRepository.Object.GetAll();
			plan.Count.ShouldBe(4);
		}
	}
}
