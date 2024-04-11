using MediatR;
using NDD.Test.Domain.Entities;

namespace NDD.Test.Application.Queries.Requests
{
    public class FindClientByIdRequest : IRequest<Client>
    {
        public Guid Id { get; set; }
    }
}
