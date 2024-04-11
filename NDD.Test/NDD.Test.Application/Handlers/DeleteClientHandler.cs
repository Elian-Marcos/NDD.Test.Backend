using MediatR;
using NDD.Test.Application.Commands.Requests;
using NDD.Test.Domain.Interfaces.Repository;

namespace NDD.Test.Application.Handlers
{
    public class DeleteClientHandler : IRequestHandler<DeleteClientRequest>
    {
        private readonly IClientRepository _clientRepository;
        public DeleteClientHandler(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<Unit> Handle(DeleteClientRequest request, CancellationToken cancellationToken)
        {
            var client = await _clientRepository.GetById(request.Id);

            if (client == null)
                throw new Exception("Not found: " + request.Id);

            await _clientRepository.DeleteAsync(client);

            return Unit.Value;
        }
    }
}
