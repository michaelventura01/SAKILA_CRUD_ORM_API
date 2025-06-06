using Microsoft.EntityFrameworkCore;

namespace SAKILA_CRUD_ORM_API.Models
{
    public class DBContext:DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) { }
        public DbSet<CategoriasUnica> categorias_unicas_pg13 { get; set; }
        public DbSet<ClienteDireccion> cliente_direccion { get; set; }
        public DbSet<ClientesRentasCategorias> clientes_rentas_categoria {  get; set; }
        public DbSet<PaisCiudadEri> pais_ciudad_eri { get; set; }
        public DbSet<PeliculasRentadasCiudades> peliculas_rentadas_ciudades { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=localhost;Database=dwh;User=root;Password=root;Port=3306", new MySqlServerVersion(new Version(8,0,13)));
            }
        }

    }
}
