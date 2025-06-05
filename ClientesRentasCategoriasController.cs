
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

        [HttpGet("AllClientesRentasCategorias")]
        public ActionResult<IEnumerable<ClientesRentasCategorias>> getClientesRentasCategorias() {
            return Ok(_clientesrentascategoriasService.GetAll());
        }

        [HttpPost("Add")]
        public ActionResult addClientesRentasCategorias(ClientesRentasCategorias clientesrentascategorias)
        {
            _clientesrentascategoriasService.Add(clientesrentascategorias);
            return Ok();
        }
    }
}
