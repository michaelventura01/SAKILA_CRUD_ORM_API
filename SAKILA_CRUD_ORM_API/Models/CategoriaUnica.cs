using System.ComponentModel.DataAnnotations;

namespace SAKILA_CRUD_ORM_API.Models
{
    public class CategoriasUnica
    {
        [Key]
        public int? id { get; set; }
        public int codigo_categoria { get; set; }
        public string categoria { get; set; }
        public string rating {  get; set; } 
        public DateTime? fecha_carga { get; set; }

        public CategoriasUnica() { 
            this.id = 0;
            this.codigo_categoria = 0;
            this.categoria = string.Empty;
            this.rating = string.Empty;
            this.fecha_carga = new DateTime();
        }
    }
}
