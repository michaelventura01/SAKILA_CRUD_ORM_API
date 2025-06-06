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

        public IEnumerable<PeliculasRentadasCiudades> GetAll() { 
            return _context.peliculas_rentadas_ciudades.ToList();
        }

        public bool Add(PeliculasRentadasCiudades peliculasrentadasciudades)
        {
            _context.peliculas_rentadas_ciudades.Add(peliculasrentadasciudades);
            int rows = _context.SaveChanges();
            return rows != 0 ? true : false;
        }

        public async Task<bool> Update(PeliculasRentadasCiudades peliculasrentadasciudades)
        {
            var _peliculasRentadasCiudades = await _context.peliculas_rentadas_ciudades.FindAsync(peliculasrentadasciudades.id);
            if (_peliculasRentadasCiudades == null)
            {
                return false;
            }

            _peliculasRentadasCiudades.codigo_pelicula = peliculasrentadasciudades.codigo_pelicula;
            _peliculasRentadasCiudades.pelicula = peliculasrentadasciudades.pelicula;
            _peliculasRentadasCiudades.ciudades_distintas = peliculasrentadasciudades.ciudades_distintas;
            _peliculasRentadasCiudades.total_2005 = peliculasrentadasciudades.total_2005;
            _peliculasRentadasCiudades.total_2006 = peliculasrentadasciudades.total_2006;
            _peliculasRentadasCiudades.porcentaje_crecimiento = peliculasrentadasciudades.porcentaje_crecimiento;

            _context.peliculas_rentadas_ciudades.Update(_peliculasRentadasCiudades);
            int rows = await _context.SaveChangesAsync();
            return rows != 0 ? true : false;
        }
    }
}
