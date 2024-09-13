namespace WebApi.Models.EntitiesResponse
{
    public class PagoResponse
    {
        public DateTime Fecha_Pago { get; set; }
        public double Monto { get; set; }
        public string Numero_Tarjeta { get; set; }
    }
}
