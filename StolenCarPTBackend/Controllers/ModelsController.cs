using Microsoft.AspNetCore.Mvc;
using StolenCarPTBackend.Business;
using StolenCarPTBackend.Data.VO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StolenCarPTBackend.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]

    public class ModelsController : ControllerBase
    {
        private readonly ILogger<ModelsController> _logger;
        private IModelsBusiness _modelsBusiness;

        public ModelsController(ILogger<ModelsController> logger, IModelsBusiness modelsBusiness)
        {
            _logger = logger;
            _modelsBusiness = modelsBusiness;
        }

        // GET: api/<ModelsController>
        [HttpGet]
        [ProducesResponseType((200), Type = typeof(List<ModelsVO>))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public IActionResult Get()
        {
            return Ok(_modelsBusiness.FindAll());
        }

        // GET api/<ModelsController>/5
        [HttpGet("{id}")]
        [ProducesResponseType((200), Type = typeof(ModelsVO))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public IActionResult Get(long id)
        {
           var model = _modelsBusiness.FindById(id);
            if (model == null) return NotFound();
            return Ok(model);
        }

        // POST api/<ModelsController>
        [HttpPost]
        [ProducesResponseType((200), Type = typeof(ModelsVO))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public IActionResult Post([FromBody] ModelsVO model)
        {
            if(model == null) return BadRequest();
            return Ok(_modelsBusiness.Create(model));
        }

        // PUT api/<ModelsController>/5
        [HttpPut("{id}")]
        [ProducesResponseType((200), Type = typeof(ModelsVO))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public IActionResult Put([FromBody] ModelsVO model)
        {
            if(model == null) return BadRequest();
            return Ok(_modelsBusiness.Update(model));
        }

        // DELETE api/<ModelsController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public IActionResult Delete(long id)
        {
            _modelsBusiness.Delete(id);
            return NoContent();
        }
    }
}
