using NDD.Test.Application.Commands.Requests;
using NDD.Test.Application.Commands.Responses;

namespace NDD.Test.Domain.Interfaces.Handler
{
    public interface ICreateClientHandler
    {
        CreateClientResponse Handle(CreateClientRequest command);
    }
}
