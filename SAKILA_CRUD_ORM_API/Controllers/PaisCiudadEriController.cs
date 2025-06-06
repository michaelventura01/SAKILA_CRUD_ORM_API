using Microsoft.AspNetCore.Mvc;
using SAKILA_CRUD_ORM_API.Models;
using SAKILA_CRUD_ORM_API.Services;

namespace SAKILA_CRUD_ORM_API.Controllers
{
    [ApiController]
    [Route("/Api/[controller]")]
    public class PaisCiudadEriController : Controller
    {
        public IConfiguration _configuration { get; set; }

        private readonly PaisCiudadEriService _paisciudaderiservice;

        public PaisCiudadEriController(IConfiguration configuration, PaisCiudadEriService paisciudaderiservice)
        {
            _configuration = configuration;
            _paisciudaderiservice = paisciudaderiservice;
        }

        [HttpGet("PaisCiudadEri")]
        public ActionResult<IEnumerable<PaisCiudadEri>> getPaisCiudadEri() {
            return Ok(_paisciudaderiservice.GetAll());
        }

        [HttpPost("Add")]
        public ActionResult addPaisCiudaderi([FromBody] PaisCiudadEri paisciudaderi)
        {
            bool answer = _paisciudaderiservice.Add(paisciudaderi);
            return Ok(answer ? "CARGADO" : "NO FUE CARGADO");
        }

        [HttpPut("Update/{id}")]
        public async Task<IActionResult> UpdatePaisCiudaderi(int id, [FromBody] PaisCiudadEri paisciudaderi)
        {
            if (id != paisciudaderi.id)
                return BadRequest("ID mismatch.");

            var updated = await _paisciudaderiservice.Update(paisciudaderi);
            if (!updated)
                return NotFound();

            return NoContent();
        }
    }
}
