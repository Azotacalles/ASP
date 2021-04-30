using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MetricsManager.Controller;
using Xunit;

namespace MetricsManagerTests
{
    public class NetworkControllerUnitTests
    {
        private NetworkMetricsController controller;

        public NetworkControllerUnitTests()
        {
            controller = new NetworkMetricsController();
        }

        [Fact]
        public void GetMetricsFromRamAvailable_ReturnsOk()
        {
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);

            var result = controller.GetMetricsFromNetwork(fromTime, toTime);

            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
