using Microsoft.AspNetCore.Mvc;

namespace DemoApp.Controllers
{
    [Route("healthcheck")]
    [ApiController]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Application is up and running";
        }
    }
}
