using MediatR;
using WebApi.Models.EntitiesResponse;

namespace WebApi.Models;

public class Compra : IRequest<EntityResponse<CompraResponse>>
{
    public DateTime Fecha { get; set; }
    public string Descripcion { get; set; }
    public double Monto { get; set; }
    public string Numero_Tarjeta { get; set; }
}
