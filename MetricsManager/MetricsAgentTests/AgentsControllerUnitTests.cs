using System;
using MetricsAgent.Controllers;
using MetricsAgent.Classes;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace MetricsAgentTests
{
    public class AgentsControllerUnitTests
    {
        private AgentsController controller;

        public AgentsControllerUnitTests()
        {
            controller = new AgentsController();
        }

        [Fact]
        public void RegisterAgent_ReturnsOk()
        {
            var agentInfo = new AgentInfo();

            var result = controller.RegisterAgent(agentInfo);

            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void EnableAgentById_ReturnsOk()
        {
            var agentId = 0;

            var result = controller.EnableAgentById(agentId);

            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void DisableAgentById_ReturnsOk()
        {
            var agentId = 0;

            var result = controller.DisableAgentById(agentId);

            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
