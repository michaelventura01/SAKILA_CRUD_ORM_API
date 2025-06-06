using System.ComponentModel.DataAnnotations;

namespace SAKILA_CRUD_ORM_API.Models
{

	public class PaisCiudadEri
	{

        [Key]
        public int? id { get; set; }
		public int codigo_pais { get; set; } 
		public string pais { get; set; }
		public int codigo_ciudad { get; set; }
		public string ciudad { get; set; }
		public DateTime? fecha_carga { get; set; }

		public PaisCiudadEri(){ 

            this.id = 0;
            this.codigo_pais = 0;
            this.pais = string.Empty;
            this.codigo_ciudad = 0;
			this.ciudad = string.Empty;
            this.fecha_carga = new DateTime();

		}
	}
} 