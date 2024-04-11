using MediatR;
using NDD.Test.Application.Commands.Responses;

namespace NDD.Test.Application.Commands.Requests
{
    public class UpdateClientRequest : IRequest
    {
        public Guid Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Observation { get; set; }
    }
}
