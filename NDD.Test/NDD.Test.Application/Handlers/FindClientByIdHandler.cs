using AutoMapper;
using MediatR;
using NDD.Test.Application.Queries.Requests;
using NDD.Test.Application.Queries.Responses;
using NDD.Test.Domain.Entities;
using NDD.Test.Domain.Interfaces.Repository;

namespace NDD.Test.Application.Handlers
{
    public class FindClientByIdHandler : IRequestHandler<FindClientByIdRequest, Client>
    {
        private readonly IClientRepository _repository;
        private readonly IMapper _mapper;
        public FindClientByIdHandler(IClientRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Client?> Handle(FindClientByIdRequest command, CancellationToken cancellation)
        {
            var result = await _repository.GetById(command.Id);

            return await Task.FromResult(result);
        }
    }
}
