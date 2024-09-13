namespace WebApi.Models.EntitiesResponse;


public class CompraResponse
{
    public DateTime Fecha { get; set; }
    public string Descripcion { get; set; }
    public double Monto { get; set; }
    public string Numero_Tarjeta { get; set; }
}
