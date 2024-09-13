using WebApi.Models;
using WebApi.Models.EntitiesResponse;
using WebApi.Repository.IRepository;

namespace WebApi.Repository
{
    public class PagoRepository : IPagoRepository
    {
        public Task<PagoResponse> AgregarPago(Pago pago)
        {
            throw new NotImplementedException();
        }

        public Task<PagoResponse> MostrarPagos(Pago pago)
        {
            throw new NotImplementedException();
        }
    }
}
