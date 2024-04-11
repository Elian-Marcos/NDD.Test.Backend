using MediatR;
using NDD.Test.Application.Queries.Responses;

namespace NDD.Test.Application.Queries.Requests
{
    public class FindClientAllRequest : IRequest<List<FindClientResponse>>
    {
    }
}
