using AutoMapper;
using MediatR;
using NDD.Test.Application.Queries.Requests;
using NDD.Test.Application.Queries.Responses;
using NDD.Test.Domain.Interfaces.Repository;

namespace NDD.Test.Application.Handlers
{
    public class FindClientByIdHandler : IRequestHandler<FindClientByIdRequest, FindClientResponse>
    {
        private readonly IClientRepository _repository;
        private readonly IMapper _mapper;
        public FindClientByIdHandler(IClientRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Task<FindClientResponse> Handle(FindClientByIdRequest command, CancellationToken cancellation)
        {
            var result = _repository.GetById(command.Id);

            var mappperResponse = _mapper.Map<FindClientResponse>(result);

            return Task.FromResult(mappperResponse);
        }
    }
}
