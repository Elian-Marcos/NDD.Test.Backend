using AutoMapper;
using MediatR;
using NDD.Test.Application.Queries.Requests;
using NDD.Test.Domain.Entities;
using NDD.Test.Domain.Interfaces.Repository;

namespace NDD.Test.Application.Handlers
{
    public class FindClientAllHandler : IRequestHandler<FindClientAllRequest, IEnumerable<Client>>
    {
        private readonly IClientRepository _clientRepository;
        private readonly IMapper _mapper;

        public FindClientAllHandler(IClientRepository clientRepository, IMapper mapper)
        {
            _clientRepository = clientRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Client>> Handle(FindClientAllRequest request, CancellationToken cancellationToken)
        {
            return await _clientRepository.GetAll();
        }

    }
}
