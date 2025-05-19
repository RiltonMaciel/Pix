using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using MediatR;
using Pay.Recorrencia.Gestao.Application.Commands.AlterarControleJornada;

namespace Pay.Recorrencia.Gestao.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlterarControleJornadaController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AlterarControleJornadaController(IMediator mediator)
        {
            _mediator = mediator;
        }

       
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] AlterarControleJornadaCommand command)
        {
            var resultado = await _mediator.Send(command);

            if (resultado.CodigoRetorno == "OK")
                return Ok(resultado);

            return BadRequest(resultado);
        }
    }
}

