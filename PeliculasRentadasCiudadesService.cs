using SAKILA_CRUD_ORM_API.Models;

namespace SAKILA_CRUD_ORM_API.Services
{
    public class PeliculasRentadasCiudadesService
    {
        private readonly DBContext _context;

        public PeliculasRentadasCiudadesService(DBContext context)
        {
            _context = context;
        }

        public IEnumerable<PeliculasRentadasCiudadesService> GetAll() { 
            return _context.tPeliculasrentadasciudades.ToList();
        }

        public void Add(PeliculasRentadasCiudades peliculasrentadasciudades)
        {
            _context.tpeliculasrentadasciudades.Add(peliculasrentadasciudades);
        }
    }
}
