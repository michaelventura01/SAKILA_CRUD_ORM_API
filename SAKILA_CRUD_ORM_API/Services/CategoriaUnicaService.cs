using SAKILA_CRUD_ORM_API.Models;

namespace SAKILA_CRUD_ORM_API.Services
{
    public class CategoriaUnicaService
    {
        private readonly DBContext _context;

        public CategoriaUnicaService(DBContext context)
        {
            _context = context;
        }

        public IEnumerable<CategoriasUnica> GetAll() { 
            return _context.categorias_unicas_pg13.ToList();
        }

        public void Add(CategoriasUnica categoria)
        {
            _context.categorias_unicas_pg13.Add(categoria);
        }
    }
}
