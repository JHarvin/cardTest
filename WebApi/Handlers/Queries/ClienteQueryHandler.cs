using MediatR;
using WebApi.Models;
using WebApi.Models.EntitiesResponse;

namespace WebApi.Handlers.Queries;

public class ClienteQueryHandler : IRequestHandler<Cliente, EntityResponse<ClienteResponse>>
{
    public Task<EntityResponse<ClienteResponse>> Handle(Cliente request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}

