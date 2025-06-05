
using SAKILA_CRUD_ORM_API.Models;

namespace SAKILA_CRUD_ORM_API.Services
{
    public class PaisCiudadEriService
    {
        private readonly DBContext _context;

        public PaisCiudadEriService(DBContext context)
        {
            _context = context;
        }

        public IEnumerable<PaisCiudadEriService> GetAll() { 
            return _context.tpaisciudaderi.ToList();
        }

        public void Add(PaisCiudadEri paisciudaderi)
        {
            _context.tpaisciudaderi.Add(paisciudaderi);
        }
    }
}
