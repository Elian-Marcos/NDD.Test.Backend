using AutoMapper;
using MediatR;
using NDD.Test.Application.Queries.Requests;
using NDD.Test.Application.Queries.Responses;
using NDD.Test.Domain.Interfaces.Repository;

namespace NDD.Test.Application.Handlers
{
    public class FindClientAllHandler : IRequestHandler<FindClientAllRequest, List<FindClientResponse>>
    {
        private readonly IClientRepository _clientRepository;
        private readonly IMapper _mapper;

        public FindClientAllHandler(IClientRepository clientRepository, IMapper mapper)
        {
            _clientRepository = clientRepository;
            _mapper = mapper;
        }

        public async Task<List<FindClientResponse>> Handle(FindClientAllRequest request, CancellationToken cancellationToken)
        {
            var clients = await _clientRepository.GetAll();

            return _mapper.Map<List<FindClientResponse>>(clients);
        }

    }
}
