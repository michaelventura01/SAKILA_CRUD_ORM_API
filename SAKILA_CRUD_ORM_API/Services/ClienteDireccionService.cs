using SAKILA_CRUD_ORM_API.Models;

namespace SAKILA_CRUD_ORM_API.Services
{
    public class ClienteDireccionService
    {
        private readonly DBContext _context;
        public ClienteDireccionService(DBContext context)
        {
            _context = context;
        }

        public IEnumerable<ClienteDireccion> GetAll()
        {
            return _context.cliente_direccion.ToList();
        }
    }
}
