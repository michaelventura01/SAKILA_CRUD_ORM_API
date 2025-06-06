
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

        public IEnumerable<PaisCiudadEri> GetAll() { 
            return _context.pais_ciudad_eri.ToList();
        }

        public bool Add(PaisCiudadEri paisciudaderi)
        {
            _context.pais_ciudad_eri.Add(paisciudaderi);
            int rows = _context.SaveChanges();
            return rows!=0?true:false;
        }

        public async Task<bool> Update(PaisCiudadEri paisciudaderi)
        {
            var _paisCiudadEri = await _context.pais_ciudad_eri.FindAsync(paisciudaderi.id);
            if (_paisCiudadEri == null)
            {
                return false;
            }

            _paisCiudadEri.codigo_pais = _paisCiudadEri.codigo_pais;
            _paisCiudadEri.pais = _paisCiudadEri.pais;
            _paisCiudadEri.codigo_ciudad = _paisCiudadEri.codigo_ciudad;
            _paisCiudadEri.ciudad = _paisCiudadEri.ciudad;

            _context.pais_ciudad_eri.Update(_paisCiudadEri);
            int rows = await _context.SaveChangesAsync();
            return rows != 0 ? true : false;
        }
    }
}
