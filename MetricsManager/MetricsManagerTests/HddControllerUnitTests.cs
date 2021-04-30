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
    public class HddControllerUnitTests
    {
        private HddMetricsController controller;

        public HddControllerUnitTests()
        {
            controller = new HddMetricsController();
        }

        [Fact]
        public void GetMetricsFromRamAvailable_ReturnsOk()
        {
            var result = controller.GetMetricsFromHddLeft();

            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
