using Microsoft.AspNetCore.Mvc;
using SAKILA_CRUD_ORM_API.Models;
using SAKILA_CRUD_ORM_API.Services;

namespace SAKILA_CRUD_ORM_API.Controllers
{
    [ApiController]
    [Route("/Api/[controller]")]
    public class ClienteDireccionController : Controller
    {
        public IConfiguration _configuration { get; set; }

        private readonly ClienteDireccionService _clienteDireccionService;

        public ClienteDireccionController(IConfiguration configuration, ClienteDireccionService clienteDireccionService)
        {
            _configuration = configuration;
            _clienteDireccionService = clienteDireccionService;
        }
        
        [HttpGet("ClienteDireccion")]
        public ActionResult<IEnumerable<ClienteDireccion>> getClientesDirecciones()
        {
            return Ok(_clienteDireccionService.GetAll());
        }

        [HttpPost("Add")]
        public ActionResult addClientesDirecciones([FromBody] ClienteDireccion clienteDireccion)
        {
            bool answer = _clienteDireccionService.Add(clienteDireccion);
            return Ok(answer ? "CARGADO" : "NO FUE CARGADO");
        }

        [HttpPut("Update/{id}")]
        public async Task<IActionResult> UpdatePaisCiudaderi(int id, [FromBody] ClienteDireccion clienteDireccion)
        {
            if (id != clienteDireccion.id)
                return BadRequest("ID mismatch.");

            var updated = await _clienteDireccionService.Update(clienteDireccion);
            if (!updated)
                return NotFound();

            return NoContent();
        }
    }
}
