using MediatR;
using System.Collections.Generic;
using WebApi.Models;
using WebApi.Models.EntitiesResponse;
using WebApi.Repository.IRepository;

namespace WebApi.Handlers.Queries;

public class CompraQueryHandler : IRequestHandler<Compra, EntityResponse<CompraResponse>>
{
    private  ICompraRepository _compraRepository;
    public CompraQueryHandler(ICompraRepository compraRepository):base()
    {
         _compraRepository = compraRepository;
    }

    public async Task<EntityResponse<CompraResponse>> Handle(Compra request, CancellationToken cancellationToken)
    {
        EntityResponse<CompraResponse> response = new EntityResponse<CompraResponse>();
        var compras = await _compraRepository.AgregarCompra(request);
        if (compras!=null) {
        
            response.Code = 200;
            response.Message = "OK";
            response.Items = compras;
        }
        else {
            response.Code = 404;
            response.Message = "Sin datos";
            response.Items = null;
        }
      

        return response;
      
    }
}

