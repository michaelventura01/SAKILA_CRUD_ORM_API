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

        public bool Add(CategoriasUnica categoria)
        {
            _context.categorias_unicas_pg13.Add(categoria);
            int rows = _context.SaveChanges();
            return rows != 0 ? true : false;
        }

        public async Task<bool> Update(CategoriasUnica categoria)
        {
            var _categoriaUnica = await _context.categorias_unicas_pg13.FindAsync(categoria.id);
            if (_categoriaUnica == null)
            {
                return false;
            }

            _categoriaUnica.codigo_categoria = categoria.codigo_categoria;
            _categoriaUnica.categoria = categoria.categoria;
            _categoriaUnica.rating = categoria.rating;


            _context.categorias_unicas_pg13.Update(_categoriaUnica);
            int rows = await _context.SaveChangesAsync();
            return rows != 0 ? true : false;
        }
    }
}
