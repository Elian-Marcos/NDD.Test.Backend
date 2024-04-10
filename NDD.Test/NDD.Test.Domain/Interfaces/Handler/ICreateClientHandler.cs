using NDD.Test.Domain.Commands.Requests;
using NDD.Test.Domain.Commands.Responses;

namespace NDD.Test.Domain.Interfaces.Handler
{
    public interface ICreateClientHandler
    {
        CreateClientResponse Handle(CreateClientRequest command);
    }
}
