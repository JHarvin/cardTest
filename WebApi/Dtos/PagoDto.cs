using System.ComponentModel.DataAnnotations;

namespace WebApi.Dtos;

public class PagoDto
{
    [Required(ErrorMessage = "La fecha de pago es requerido")]
    public DateTime Fecha_Pago { get; set; }
    [Required(ErrorMessage = "El monto es requerido")]
    public double Monto { get; set; }
    [Required(ErrorMessage = "El número de tarjeta es requerido")]
    public string Numero_Tarjeta { get; set; }
}
