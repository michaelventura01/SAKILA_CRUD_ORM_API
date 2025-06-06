using Microsoft.AspNetCore.Mvc;
using SAKILA_CRUD_ORM_API.Models;
using SAKILA_CRUD_ORM_API.Services;

namespace SAKILA_CRUD_ORM_API.Controllers
{
    [ApiController]
    [Route("/Api/[controller]")]
    public class CategoriasController : Controller
    {
        public IConfiguration _configuration { get; set; }

        private readonly CategoriaUnicaService _categoriaService;

        public CategoriasController(IConfiguration configuration, CategoriaUnicaService categoriaService)
        {
            _configuration = configuration;
            _categoriaService = categoriaService;
        }

        [HttpGet("CategoriasUnicas")]
        public ActionResult<IEnumerable<CategoriasUnica>> getCategorias() {
            return Ok(_categoriaService.GetAll());
        }

        [HttpPost("Add")]
        public ActionResult addCategorias([FromBody] CategoriasUnica categoria)
        {
            bool answer = _categoriaService.Add(categoria);
            return Ok(answer?"CARGADO":"NO FUE CARGADO");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategoria(int id, [FromBody] CategoriasUnica categoria)
        {
            if (id != categoria.id)
                return BadRequest("ID mismatch.");

            var updated = await _categoriaService.Update(categoria);
            if (!updated)
                return NotFound();

            return NoContent();
        }
    }
}
