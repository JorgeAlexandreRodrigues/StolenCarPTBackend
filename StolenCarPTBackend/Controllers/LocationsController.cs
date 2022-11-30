using Microsoft.AspNetCore.Mvc;
using StolenCarPTBackend.Business;
using StolenCarPTBackend.Data.VO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StolenCarPTBackend.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    
    public class LocationsController : ControllerBase
    {
        private readonly ILogger<LocationsController> _logger;
        private ILocationsBusiness _locationsBusiness;

        public LocationsController(ILogger<LocationsController> logger, ILocationsBusiness locationsBusiness)
        {
            _logger = logger;
            _locationsBusiness = locationsBusiness;
        }

        // GET: api/<LocationsController>
        [HttpGet]
        [ProducesResponseType((200), Type = typeof(List<LocationsVO>))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public IActionResult Get()
        {
            return Ok(_locationsBusiness.FindAll());
        }

        // GET api/<LocationsController>
        [HttpGet("{id}")]
        [ProducesResponseType((200), Type = typeof(LocationsVO))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public IActionResult Get(long id)
        {
            var location = (_locationsBusiness.FindById(id));
            if (location == null) return NotFound();
            return Ok(location);
        }

        // POST api/<LocationsController>
        [HttpPost]
        [ProducesResponseType((200), Type = typeof(LocationsVO))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public IActionResult Post([FromBody] LocationsVO locations)
        {
            if (locations == null) return BadRequest();
            return Ok(_locationsBusiness.Create(locations));
        }

        // PUT api/<LocationsController>
        [HttpPut("{id}")]
        [ProducesResponseType((200), Type = typeof(LocationsVO))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public IActionResult Put([FromBody] LocationsVO locations)
        {
            if (locations == null) return BadRequest();
            return Ok(_locationsBusiness.Update(locations));
        }

        // DELETE api/<LocationsController>
        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public IActionResult Delete(long id)
        {
            _locationsBusiness.Delete(id);
            return NoContent();
        }
    }
}
