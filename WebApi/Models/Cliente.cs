using MediatR;
using WebApi.Models.EntitiesResponse;

namespace WebApi.Models;

public class Cliente : IRequest<EntityResponse<ClienteResponse>>
{

    public string Nombre { get; set; }
    public string Numero_Tarjeta { get; set; }
    public double Monto { get; set; }
    public double Limite_Monto { get; set; }
}
