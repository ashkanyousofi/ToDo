using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.Contracts.Persistence.Dapper;
using ToDo.Domain.Entities.ToDo;

namespace ToDo.UnitTest.Mocks
{
    public static class MockPlanRepository
	{
		public static Mock<IManageToDoDapper> GetPlanRepository()
		{
			var plans = new List<Plan>()
			{
				new Plan() {},
				new Plan() {},
				new Plan() {},
			};

			var mockRepo = new Mock<IManageToDoDapper>();
			mockRepo.Setup(m => m.GetAll()).ReturnsAsync(plans);

			return mockRepo;
		}
	}
}
