using MediatR;
using Microsoft.AspNetCore.Mvc;
using NDD.Test.Application.Commands.Requests;
using NDD.Test.Application.Queries.Requests;

namespace NDD.Test.WebApi.Presentation.Controllers
{
    [ApiController]
    [Route("clients")]
    public class ClientController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public IActionResult Create([FromServices]IMediator mediator, [FromBody]CreateClientRequest command)
        {
            var response = mediator.Send(command);
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
        [Route("GetAll")]
        public IActionResult GetAll([FromServices] IMediator mediator, [FromQuery] FindClientAllRequest command)
        {
            var response = mediator.Send(command);
            return Ok(response);
        }

        [HttpPut]
        [Route("Update")]
        public IActionResult Update([FromServices]IMediator mediator, [FromBody]UpdateClientRequest command)
        {
            var response = mediator.Send(command);
            return Ok(response);
        }


        [HttpPut]
        [Route("Delete")]
        public IActionResult Delete([FromServices] IMediator mediator, [FromBody] DeleteClientRequest command)
        {
            var response = mediator.Send(command);
            return Ok(response);
        }
    }
}
