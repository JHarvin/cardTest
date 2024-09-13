
using AutoMapper;
using WebApi.Dtos;
using WebApi.Models;

namespace WebApi.ApiMapper
{
    public class CardMaper : Profile
    {
        public CardMaper()
        {
            CreateMap<Cliente, ClienteDto>().ReverseMap();
            CreateMap<Compra, CompraDto>().ReverseMap();
            CreateMap<Pago, PagoDto>().ReverseMap();
      
        }
    }
}
