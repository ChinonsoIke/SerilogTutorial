using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace SerilogTutorial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        [HttpPost("test-logger")]
        public ActionResult TestLogger()
        {
            Log.Information("This log is from the global Log class");
            _logger.LogInformation("This log is from the injected ILogger");
            return Ok();
        }
    }
}
