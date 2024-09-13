using MediatR;
using WebApi.Models;
using WebApi.Models.EntitiesResponse;

namespace WebApi.Handlers.Queries;

public class PagoQueryHandler : IRequestHandler<Pago, EntityResponse<PagoResponse>>
{
    public Task<EntityResponse<PagoResponse>> Handle(Pago request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}

