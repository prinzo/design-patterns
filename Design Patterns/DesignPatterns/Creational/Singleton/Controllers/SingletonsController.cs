using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Creational.Singleton.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SingletonsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            // Simple usage of our singleton

            //var configHandler = ConfigHandler.Instance;
            //return this.Ok(configHandler.GetConfiguration());

            // Prove that they are the same
            var configHandler = ConfigHandler.Instance;
            var configHandler2 = ConfigHandler.Instance;

            return this.Ok(configHandler2 == configHandler);
        }
    }
}
