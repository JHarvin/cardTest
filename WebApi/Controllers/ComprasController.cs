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
public class ComprasController : Controller
{
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;

    public ComprasController(IMapper mapper, IMediator mediator)
    {
        _mapper = mapper;
        _mediator = mediator;
    }

    /*public IActionResult Index()
    {
        return View();
    }*/
    
    [HttpPost("addcompra")]
    [ProducesResponseType(200, Type = typeof(EntityResponse<CompraResponse>))]
    
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> guardarCompra([FromBody] CompraDto compraDto) 
    {
        if (compraDto == null) {
        return BadRequest(ModelState);
        }
        var compra= await _mediator.Send(_mapper.Map<Compra>(compraDto));


        return new JsonResult(compra);
    }
}
