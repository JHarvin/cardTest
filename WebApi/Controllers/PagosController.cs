using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApi.Dtos;
using WebApi.Models;
using WebApi.Models.EntitiesResponse;

namespace WebApi.Controllers;

[Route("api/Compras")]
[ApiController]
[ApiExplorerSettings(GroupName = "Compras")]
public class PagosController : Controller
{
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;

    public PagosController(IMapper mapper, IMediator mediator)
    {
        _mapper = mapper;
        _mediator = mediator;
    }

    /*public IActionResult Index()
    {
        return View();
    }*/
    
    [HttpPost("addpayment")]
    [ProducesResponseType(200, Type = typeof(EntityResponse<PagoResponse>))]
    
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> guardarCompra([FromBody] PagoDto compraDto) 
    {
        if (compraDto == null) {
        return BadRequest(ModelState);
        }
        var compra= await _mediator.Send(_mapper.Map<Pago>(compraDto));


        return new JsonResult(compra);
    }
}
