using DesignPatterns.Creational.Factory.Factories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Creational.Factory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FactoriesController : ControllerBase
    {
        private readonly IBeverageMaker _beverageMaker;

        public FactoriesController(IBeverageMaker beverageMaker)
        {
            _beverageMaker = beverageMaker;
        }
        
        [HttpGet]
        [Route("Beverage")]
        public IActionResult GetBeverage()
        {
            return Ok(_beverageMaker.MakeBeverage());
        }
    }
}
