

using Microsoft.AspNetCore.Mvc;
using SAKILA_CRUD_ORM_API.Models;
using SAKILA_CRUD_ORM_API.Services;

namespace SAKILA_CRUD_ORM_API.Controllers
{
    [ApiController]
    [Route("/Api/[controller]")]
    public class PeliculasRentadasCiudadesController : Controller
    {
        public IConfiguration _configuration { get; set; }

        private readonly PeliculasRentadasCiudadesService _peliculasrentadasciudadesservice;

        public PeliculasRentadasCiudadesController(IConfiguration configuration, PeliculasRentadasCiudadesService peliculasrentadasciudadesservices)
        {
            _configuration = configuration;
            _peliculasrentadasciudadesservice = peliculasrentadasciudadesservices;
        }

        [HttpGet("PeliculasRentadasCiudades")]
        public ActionResult<IEnumerable<PeliculasRentadasCiudades>> getPeliculasRetadasCiudades() {
            return Ok(_peliculasrentadasciudadesservice.GetAll());
        }

        [HttpPost("Add")]
        public ActionResult addPeliculasRentadasCiudades([FromBody] PeliculasRentadasCiudades peliculasrentadasciudades)
        {
            bool answer = _peliculasrentadasciudadesservice.Add(peliculasrentadasciudades);
            return Ok(answer ? "CARGADO" : "NO FUE CARGADO");
        }

        [HttpPut("Update/{id}")]
        public async Task<IActionResult> UpdatePaisCiudaderi(int id, [FromBody] PeliculasRentadasCiudades peliculasrentadasciudades)
        {
            if (id != peliculasrentadasciudades.id)
                return BadRequest("ID mismatch.");

            var updated = await _peliculasrentadasciudadesservice.Update(peliculasrentadasciudades);
            if (!updated)
                return NotFound();

            return NoContent();
        }
    }
} 