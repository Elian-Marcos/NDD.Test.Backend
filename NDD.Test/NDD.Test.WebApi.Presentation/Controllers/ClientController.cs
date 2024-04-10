using Microsoft.AspNetCore.Mvc;
using NDD.Test.Domain.Commands.Requests;
using NDD.Test.Domain.Interfaces.Handler;

namespace NDD.Test.WebApi.Presentation.Controllers
{
    [ApiController]
    [Route("clients")]
    public class ClientController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public IActionResult CreateClient([FromServices]ICreateClientHandler handler, [FromBody]CreateClientRequest command)
        {
            var response = handler.Handle(command);
            return Ok(response);
        }
    }
}
