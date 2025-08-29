using Microsoft.AspNetCore.Mvc;

namespace Raw_Solutions_TEST_Web_App.Controllers
{
    [ApiController]
    public class HealthController : ControllerBase
    {
        [HttpGet("/health")]
        public IActionResult Get() => Ok("OK");
    }
}
