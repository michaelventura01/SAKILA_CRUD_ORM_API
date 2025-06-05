using SAKILA_CRUD_ORM_API.Models;

namespace SAKILA_CRUD_ORM_API.Services
{
    public class ClientesRentasCategoriasService
    {
        private readonly DBContext _context;

        public ClientesRentasCategoriasService(DBContext context)
        {
            _context = context;
        }

        public IEnumerable<ClientesRentasCategorias> GetAll() { 
            return _context.tclientesRentasCategorias.ToList();
        }

        public void Add(ClientesRentasCategorias clienteRentaCategoria)
        {
            _context.tclientesRentasCategorias.Add(clienteRentaCategoria);
        }
    }
}
