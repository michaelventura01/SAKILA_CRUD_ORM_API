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

        [HttpGet("AllCategoriasUnicas")]
        public ActionResult<IEnumerable<CategoriasUnica>> getCategorias() {
            return Ok(_categoriaService.GetAll());
        }

        [HttpPost("Add")]
        public ActionResult addCategorias(CategoriasUnica categoria)
        {
            _categoriaService.Add(categoria);
            return Ok();
        }
    }
}
