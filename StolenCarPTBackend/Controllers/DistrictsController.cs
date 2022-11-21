using Microsoft.AspNetCore.Mvc;
using StolenCarPTBackend.Model;
using StolenCarPTBackend.Business;

namespace StolenCarPTBackend.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class DistrictsController : ControllerBase
    { 

        private readonly ILogger<DistrictsController> _logger;
        private IDistrictsService _districtsService;

        public DistrictsController(ILogger<DistrictsController> logger, IDistrictsService districtsService)
        {
            _logger = logger;
            _districtsService = districtsService;
        }

        [HttpGet]
        
        public IActionResult Get()
        {
            return Ok(_districtsService.FindAll());
        }

        [HttpGet("{id}")]

        public IActionResult Get(long id)
        {
            var district = (_districtsService.FindById(id));
            if (district == null) return NotFound();
            return Ok(district);
        }

        [HttpPost]

        public IActionResult Post([FromBody] Districts districts)
        {
            if (districts == null) return BadRequest();
            return Ok(_districtsService.Create(districts));
        }


        [HttpPut]

        public IActionResult Put([FromBody] Districts districts)
        {
            if (districts == null) return BadRequest();
            return Ok(_districtsService.Update(districts));
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(long id)
        {
            _districtsService.Delete(id);
            return NoContent();
        }
    }
}