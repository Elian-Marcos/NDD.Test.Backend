using MediatR;
using NDD.Test.Domain.Entities;

namespace NDD.Test.Application.Queries.Requests
{
    public class FindClientAllRequest : IRequest<IEnumerable<Client>>
    {
    }
}
