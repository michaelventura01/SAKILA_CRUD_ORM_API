
using Microsoft.AspNetCore.Mvc;
using SAKILA_CRUD_ORM_API.Models;
using SAKILA_CRUD_ORM_API.Services;

namespace SAKILA_CRUD_ORM_API.Controllers
{
    [ApiController]
    [Route("/Api/[controller]")]
    public class ClientesRentasCategoriasController : Controller
    {
        public IConfiguration _configuration { get; set; }

        private readonly ClientesRentasCategoriasService _clientesrentascategoriasService;

        public ClientesRentasCategoriasController(IConfiguration configuration, ClientesRentasCategoriasService clientesrentascategoriasService)
        {
            _configuration = configuration;
            _clientesrentascategoriasService = clientesrentascategoriasService;
        }

        [HttpGet("ClientesRentasCategorias")]
        public ActionResult<IEnumerable<ClientesRentasCategorias>> getClientesRentasCategorias() {
            return Ok(_clientesrentascategoriasService.GetAll());
        }

        [HttpPost("Add")]
        public ActionResult addClientesRentasCategorias([FromBody] ClientesRentasCategorias clientesrentascategorias)
        {
            bool answer = _clientesrentascategoriasService.Add(clientesrentascategorias);
            return Ok(answer ? "CARGADO" : "NO FUE CARGADO");
        }

        [HttpPut("Update/{id}")]
        public async Task<IActionResult> UpdateClientesRentasCategorias(int id, [FromBody] ClientesRentasCategorias clientesrentascategorias)
        {
            if (id != clientesrentascategorias.id)
                return BadRequest("ID mismatch.");

            var updated = await _clientesrentascategoriasService.Update(clientesrentascategorias);
            if (!updated)
                return NotFound();

            return NoContent();
        }
    }
}
