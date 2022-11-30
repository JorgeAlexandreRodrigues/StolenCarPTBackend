using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StolenCarPTBackend.Business;
using StolenCarPTBackend.Data.VO;

namespace StolenCarPTBackend.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class BrandsController : ControllerBase
    {
        private readonly ILogger<BrandsController> _logger; 
        private IBrandsBusiness _brandsBusiness;

        public BrandsController(ILogger<BrandsController> logger, IBrandsBusiness brandsBusiness)
        {
            _logger = logger;
            _brandsBusiness = brandsBusiness;

        }

        [HttpGet]
        [ProducesResponseType((200), Type= typeof(List<BrandsVO>))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public IActionResult Get()
        {
            return Ok(_brandsBusiness.FindAll());
        }

        [HttpGet("{id}")]
        [ProducesResponseType((200), Type = typeof(BrandsVO))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public IActionResult Get(long id)
        {
            var brand = _brandsBusiness.FindById(id);
            if (brand == null) return NotFound();
            return Ok(brand);   
        }

        [HttpPost]
        [ProducesResponseType((200), Type = typeof(BrandsVO))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public IActionResult Post([FromBody] BrandsVO brands)
        {
            if (brands == null) return BadRequest();
            return Ok(_brandsBusiness.Create(brands));
        }

        [HttpPut]
        [ProducesResponseType((200), Type = typeof(BrandsVO))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public IActionResult Put([FromBody] BrandsVO brands)
        {
            if (brands == null) return BadRequest();
            return Ok(_brandsBusiness.Update(brands));
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public IActionResult Delete(long id)
        {
            _brandsBusiness.Delete(id);
            return NoContent();
        }
    }
}
