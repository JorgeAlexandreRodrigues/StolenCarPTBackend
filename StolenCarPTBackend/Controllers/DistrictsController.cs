using Microsoft.AspNetCore.Mvc;
using StolenCarPTBackend.Business;
using StolenCarPTBackend.Data.VO;

namespace StolenCarPTBackend.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class DistrictsController : ControllerBase
    { 

        private readonly ILogger<DistrictsController> _logger;
        private IDistrictsBusiness _districtsBusiness;

        public DistrictsController(ILogger<DistrictsController> logger, IDistrictsBusiness districtsBusiness)
        {
            _logger = logger;
            _districtsBusiness = districtsBusiness;
        }

        [HttpGet]
        
        public IActionResult Get()
        {
            return Ok(_districtsBusiness.FindAll());
        }

        [HttpGet("{id}")]

        public IActionResult Get(long id)
        {
            var district = (_districtsBusiness.FindById(id));
            if (district == null) return NotFound();
            return Ok(district);
        }

        [HttpPost]

        public IActionResult Post([FromBody] DistrictsVO districts)
        {
            if (districts == null) return BadRequest();
            return Ok(_districtsBusiness.Create(districts));
        }


        [HttpPut]

        public IActionResult Put([FromBody] DistrictsVO districts)
        {
            if (districts == null) return BadRequest();
            return Ok(_districtsBusiness.Update(districts));
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(long id)
        {
            _districtsBusiness.Delete(id);
            return NoContent();
        }
    }
}