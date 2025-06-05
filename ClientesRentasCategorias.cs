namespace SAKILA_CRUD_ORM_API.Models
{
	public class ClientesRentasCategorias
	{
    
		public int id { get; set; }
		public int codigo_cliente { get; set; } 
		public string nombre_cliente { get; set; }
		public string apellido_cliente { get; set; }
		public float total_facturado { get; set; }
		public int total_renta { get; set; }
		public string categoria_cliente { get; set; } 
		public DateTime fecha_carga { get; set; }

		public ClientesRentasCategorias(){ 

            this.id = 0;
            this.codigo_cliente = 0;
			this.nombre_cliente = string.Empty;
			this.apellido_cliente = string.Empty;
            this.total_facturado = 0.0f;
			this.total_renta = 0;
			this.categoria_cliente = string.Empty;
            this.fecha_carga = new DateTime();

		}
	}
} 