using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Drivers.api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Drivers.api.Controllers
{
    [Route("api/[controller]")]
    public class DriverController : ControllerBase
    {
        private readonly ILogger<DriverController> _logger;
        private readonly DriverService _driverService;

        public DriverController(ILogger<DriverController> logger, DriverService driverService)
        {
            _logger = logger;
            _driverService = driverService;
        }

        //create a Get method
        [HttpGet]
        public async Task<IActionResult> GetAllDrivers()
        {
            var listAllDrivers = await _driverService.GetDriversAsync();
            return Ok(listAllDrivers);
        }

    }
}