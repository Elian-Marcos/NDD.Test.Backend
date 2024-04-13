using MediatR;
using Microsoft.AspNetCore.Mvc;
using NDD.Test.Application.Commands.Requests;
using NDD.Test.Application.Queries.Requests;
using NDD.Test.Domain.Entities;

namespace NDD.Test.WebApi.Presentation.Controllers
{
    [ApiController]
    [Route("api/v1/clients")]
    public class ClientController : ControllerBase
    {
        [HttpPost]
        [Route("create")]
        public async Task<ActionResult<Client>> Create([FromServices]IMediator mediator, [FromBody]CreateClientRequest command)
        {
                var response = await mediator.Send(command);
                return Ok(response);
        }

        [HttpGet]
        [Route("getById")]
        public async Task<ActionResult<Client>> GetById([FromServices]IMediator mediator, [FromQuery] FindClientByIdRequest command)
        {
            var response = await mediator.Send(command);
            if (response == null)
                return NotFound();
            return Ok(response);
        }

        [HttpGet]
        [Route("getAll")]
        public async Task<ActionResult<IEnumerable<Client>>> GetAll([FromServices] IMediator mediator, [FromQuery] FindClientAllRequest command)
        {
            var response = await mediator.Send(command);
            return Ok(response);
        }

        [HttpPut]
        [Route("update")]
        public async Task<ActionResult<Client>> Update([FromServices]IMediator mediator, [FromBody]UpdateClientRequest command)
        {
            var response = await mediator.Send(command);
            return Ok(response);
        }


        [HttpPost]
        [Route("delete")]
        public async Task<IActionResult> Delete([FromServices] IMediator mediator, DeleteClientRequest command)
        {
            await mediator.Send(command);
            return NoContent();
        }
    }
}
