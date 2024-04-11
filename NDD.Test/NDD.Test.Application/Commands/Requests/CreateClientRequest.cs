using MediatR;
using NDD.Test.Application.Commands.Responses;

namespace NDD.Test.Application.Commands.Requests
{
    public class CreateClientRequest : IRequest<CreateClientResponse>
    {
        public string Name { get; set; }
        public string CPF { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Observation { get; set; }
    }
}
