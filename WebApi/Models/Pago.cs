using MediatR;
using WebApi.Models.EntitiesResponse;

namespace WebApi.Models;

public class Pago : IRequest<EntityResponse<PagoResponse>>
{
    public DateTime Fecha_Pago { get; set; }
    public double Monto { get; set; }
    public string Numero_Tarjeta { get; set; }
}
