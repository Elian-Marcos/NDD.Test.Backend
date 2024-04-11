using MediatR;
using NDD.Test.Application.Queries.Responses;

namespace NDD.Test.Application.Queries.Requests
{
    public class FindClientByIdRequest : IRequest<FindClientResponse>
    {
        public Guid Id { get; set; }
    }
}
