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
        
        [HttpGet("AllClienteDireccion")]
        public ActionResult<IEnumerable<ClienteDireccion>> getClientesDirecciones()
        {
            return Ok(_clienteDireccionService.GetAll());
        }

    }
}
