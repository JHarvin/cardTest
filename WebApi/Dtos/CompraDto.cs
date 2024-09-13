using System.ComponentModel.DataAnnotations;

namespace WebApi.Dtos;

public class CompraDto
{
    [Required(ErrorMessage = "La fecha es requerida")]
    public DateTime Fecha { get; set; }
    [Required(ErrorMessage = "La descripcion es requerido")]
    public string Descripcion { get; set; }
    [Required(ErrorMessage = "El monto es requerido")]
    public double Monto { get; set; }
    [Required(ErrorMessage = "El número de tarjeta es requerido")]
    public string Numero_Tarjeta { get; set; }
}
