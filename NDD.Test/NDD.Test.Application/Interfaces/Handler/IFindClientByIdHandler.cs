using NDD.Test.Application.Queries.Requests;
using NDD.Test.Application.Queries.Responses;

namespace NDD.Test.Application.Interfaces.Handler
{
    public interface IFindClientByIdHandler
    {
        Task<FindClientResponse> Handle(FindClientByIdRequest command);
    }
}
