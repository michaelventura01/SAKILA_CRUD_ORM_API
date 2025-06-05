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

        [HttpGet("AllPaisCiudadEri")]
        public ActionResult<IEnumerable<PaisCiudadEri>> getPaisCiudadEri() {
            return Ok(_paisciudaderiservice.GetAll());
        }

        [HttpPost("Add")]
        public ActionResult addPaisCiudaderi(PaisCiudadEri paisciudaderi)
        {
            _paisciudaderiservice.Add(paisciudaderi);
            return Ok();
        }
    }
}
