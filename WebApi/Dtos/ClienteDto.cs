
using System.ComponentModel.DataAnnotations;


namespace WebApi.Dtos;

public class ClienteDto 
{
    [Required(ErrorMessage ="El nombre es requerido")]
    public string Nombre { get; set; }
    [Required(ErrorMessage = "El número de tarjeta es obligatorio")]
    public string Numero_Tarjeta { get; set; }
    [Required(ErrorMessage = "El monto es requerido")]
    public double Monto { get; set; }
    [Required(ErrorMessage = "El limite del monto es requerido")]
    public double Limite_Monto { get; set; }
}
