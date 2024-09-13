using WebApi.Models;
using WebApi.Models.EntitiesResponse;

namespace WebApi.Repository.IRepository;

public interface ICompraRepository
{
    Task<List<CompraResponse>> AgregarCompra(Compra compra);
    Task<CompraResponse> MostrarCompras(Compra compra);

}
