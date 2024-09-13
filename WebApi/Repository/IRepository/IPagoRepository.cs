using WebApi.Models;
using WebApi.Models.EntitiesResponse;

namespace WebApi.Repository.IRepository;

public interface IPagoRepository
{
    Task<PagoResponse> AgregarPago(Pago pago);
    Task<PagoResponse> MostrarPagos(Pago pago);
}
