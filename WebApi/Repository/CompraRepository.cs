using Dapper;
using System.Data;
using System.Data.SqlClient;
using WebApi.Models;
using WebApi.Models.EntitiesResponse;
using WebApi.Repository.IRepository;

namespace WebApi.Repository;

public class CompraRepository : ICompraRepository
{
    private readonly IDbConnection _dbconnection;
    private readonly string _connectionString;
    public CompraRepository(string connectionString)
    {

        _connectionString = connectionString;
        

    }

    public async Task<List<CompraResponse>> AgregarCompra(Compra compra)
    {
        var query = @"SELECT * FROM compra";
        try { 
            using (var conexion = new SqlConnection(_connectionString) )
            {
           
                return (List<CompraResponse>)await conexion.QueryAsync<CompraResponse>(query);
            }
       }catch(InvalidOperationException ex) {
            
            
            return null;
        }
    
    }

    public Task<CompraResponse> MostrarCompras(Compra compra)
    {
        throw new NotImplementedException();
    }
}
