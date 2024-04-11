using MediatR;
using Microsoft.AspNetCore.Mvc;
using NDD.Test.Application.Commands.Requests;
using NDD.Test.Application.Queries.Requests;

namespace NDD.Test.WebApi.Presentation.Controllers
{
    [ApiController]
    [Route("api/v1/clients")]
    public class ClientController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Create([FromServices]IMediator mediator, [FromBody]CreateClientRequest command)
        {
            var response = await mediator.Send(command);
            return Ok(response);
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetById([FromServices]IMediator mediator, [FromQuery] FindClientByIdRequest command)
        {
            var response = mediator.Send(command);
            return Ok(response);
        }

        [HttpGet]
        [Route("getAll")]
        public IActionResult GetAll([FromServices] IMediator mediator, [FromQuery] FindClientAllRequest command)
        {
            var response = mediator.Send(command);
            return Ok(response);
        }

        [HttpPut]
        [Route("update")]
        public IActionResult Update([FromServices]IMediator mediator, [FromBody]UpdateClientRequest command)
        {
            var response = mediator.Send(command);
            return Ok(response);
        }


        [HttpPut]
        [Route("delete")]
        public IActionResult Delete([FromServices] IMediator mediator, [FromBody] DeleteClientRequest command)
        {
            var response = mediator.Send(command);
            return Ok(response);
        }
    }
}
