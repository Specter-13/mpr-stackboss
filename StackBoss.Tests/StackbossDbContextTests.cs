using StackBoss.Web.Data;
using StackBoss.Web.Data.Services;
using System;
using Xunit;

namespace StackBoss.Tests
{
    public class StackbossDbContextTests
    {
        private readonly ApplicationDbContext _testContext;
        private readonly ProjectService _projectService;
        public StackbossDbContextTests()
        {
            var setup = new StackbossDbContextSetup("testDb");
            _testContext = setup.DbContextFactory.CreateDbContext();
            _projectService = new ProjectService(_testContext);
            setup.PrepareDatabase();
        }
        [Fact]
        public async void Projects_GetAll()
        {
            int numberOfInterprets = 1;


            var projectList = await _projectService.GetAllProjectsAsync();

            Assert.Equal(numberOfInterprets, projectList.Count);

        }
    }
}
