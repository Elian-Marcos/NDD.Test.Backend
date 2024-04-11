using MediatR;

namespace NDD.Test.Application.Commands.Requests
{
    public class DeleteClientRequest : IRequest
    {
        public Guid Id { get; set; }
    }
}
