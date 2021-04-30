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
    public class RamControllerUnitTests
    {
        private RamMetricsController controller;

        public RamControllerUnitTests()
        {
            controller = new RamMetricsController();
        }

        [Fact]
        public void GetMetricsFromRamAvailable_ReturnsOk()
        {
            var result = controller.GetMetricsFromRamAvailable();

            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
