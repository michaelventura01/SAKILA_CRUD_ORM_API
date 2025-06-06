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
            return _context.clientes_rentas_categoria.ToList();
        }

        public bool Add(ClientesRentasCategorias clienteRentaCategoria)
        {
            _context.clientes_rentas_categoria.Add(clienteRentaCategoria);
            int rows = _context.SaveChanges();
            return rows != 0 ? true : false;
        }

        public async Task<bool> Update(ClientesRentasCategorias clienteRentaCategoria)
        {
            var _clientesRentasCategorias = await _context.clientes_rentas_categoria.FindAsync(clienteRentaCategoria.id);
            if (_clientesRentasCategorias == null)
            {
                return false;
            }

            _clientesRentasCategorias.codigo_cliente = clienteRentaCategoria.codigo_cliente;
            _clientesRentasCategorias.nombre_cliente = clienteRentaCategoria.nombre_cliente;
            _clientesRentasCategorias.apellido_cliente = clienteRentaCategoria.apellido_cliente;
            _clientesRentasCategorias.total_facturado = clienteRentaCategoria.total_facturado;
            _clientesRentasCategorias.total_renta = clienteRentaCategoria.total_renta;
            _clientesRentasCategorias.categoria_cliente = clienteRentaCategoria.categoria_cliente;

            _context.clientes_rentas_categoria.Update(_clientesRentasCategorias);
            int rows = await _context.SaveChangesAsync();
            return rows != 0 ? true : false;
        }
    }
}
