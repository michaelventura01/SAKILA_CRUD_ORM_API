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

        public bool Add(ClienteDireccion clienteDireccion)
        {
            _context.cliente_direccion.Add(clienteDireccion);
            int rows = _context.SaveChanges();
            return rows != 0 ? true : false;
        }

        public async Task<bool> Update(ClienteDireccion clienteDireccion)
        {
            var _clienteDireccion = await _context.cliente_direccion.FindAsync(clienteDireccion.id);
            if (_clienteDireccion == null)
            {
                return false;
            }

            _clienteDireccion.codigo_Cliente = clienteDireccion.codigo_Cliente;
            _clienteDireccion.nombre = clienteDireccion.nombre;
            _clienteDireccion.apellido = clienteDireccion.apellido;
            _clienteDireccion.codigo_ciudad = clienteDireccion.codigo_ciudad;
            _clienteDireccion.ciudad = clienteDireccion.ciudad;
            _clienteDireccion.codigo_pais = clienteDireccion.codigo_pais;
            _clienteDireccion.pais = clienteDireccion.pais;
            _clienteDireccion.direccion = clienteDireccion.direccion;


            _context.cliente_direccion.Update(_clienteDireccion);
            int rows = await _context.SaveChangesAsync();
            return rows != 0 ? true : false;
        }
    }
}
