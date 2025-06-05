namespace SAKILA_CRUD_ORM_API.Models
{
	public class PeliculasRentadasCiudades
	{
    
		public int id { get; set; }
		public int codigo_pelicula { get; set; } 
		public string pelicula { get; set; }
		public int ciudades_distintas { get; set; }
		public float total_2005 { get; set; }
		public float total_2006 { get; set; }
		public float porcentaje_crecimiento { get; set; } 
		public DateTime fecha_carga { get; set; }

		public PeliculasRentadasCiudades(){ 

            this.id = 0;
            this.codigo_pelicula = 0;
			this.pelicula = string.Empty;
            this.ciudades_distintas = 0;
			this.total_2005 = 0.0f;
			this.total_2006 = 0.0f;
			this.porcentaje_crecimiento = 0.0f;
            this.fecha_carga = new DateTime();

		}
	}
} 