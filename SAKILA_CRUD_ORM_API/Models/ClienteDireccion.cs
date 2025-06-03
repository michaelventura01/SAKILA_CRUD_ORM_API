using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SAKILA_CRUD_ORM_API.Models
{
    public class ClienteDireccion
    {
        public int id {  get; set; }
        public int codigo_Cliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int codigo_ciudad { get; set; }
        public string ciudad { get; set; }
        public int codigo_pais { get; set; }
        public string pais { get; set; }
        public string direccion { get; set; }
        public DateTime fecha_Carga { get; set; }

        public ClienteDireccion()
        {
            this.id = 0;
            this.codigo_Cliente = 0;
            this.nombre = string.Empty;
            this.apellido = string.Empty;
            this.codigo_ciudad = 0;
            this.ciudad = string.Empty;
            this.codigo_pais = 0;
            this.pais = string.Empty;
            this.direccion = string.Empty;
            this.fecha_Carga = new DateTime();
        }
    }
}
