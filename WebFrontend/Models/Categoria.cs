using System.ComponentModel.DataAnnotations;

namespace WebFrontend.Models
{
    public class Categoria
    {
        public int Id_Categoria { get; set; }
        [Required(ErrorMessage ="El nombre es obligatorio")]
        public string Nombre { get; set; }
    }
}
