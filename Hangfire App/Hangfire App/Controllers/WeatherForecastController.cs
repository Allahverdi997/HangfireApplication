using Hangfire_App.Process;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hangfire_App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public IWirteFile WirteFile { get; set; }
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,IWirteFile wirteFile)
        {
            _logger = logger;
            WirteFile = wirteFile;
        }

        [HttpGet]
        public IActionResult Get()
        {
            WirteFile.Write(DateTime.Now.ToString());
            MyHangfire.HangfireBackgroundJob.Operation();
            return Ok();
        }
    }
}
