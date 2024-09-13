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
public class ClientesController : Controller
{
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;

    public ClientesController(IMapper mapper, IMediator mediator)
    {
        _mapper = mapper;
        _mediator = mediator;
    }

    /*public IActionResult Index()
    {
        return View();
    }*/
    
    [HttpPost("addtarget")]
    [ProducesResponseType(200, Type = typeof(EntityResponse<ClienteResponse>))]
    
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> guardarCliente([FromBody] ClienteDto compraDto) 
    {
        if (compraDto == null) {
        return BadRequest(ModelState);
        }
        var compra= await _mediator.Send(_mapper.Map<Cliente>(compraDto));


        return new JsonResult(compra);
    }
}
