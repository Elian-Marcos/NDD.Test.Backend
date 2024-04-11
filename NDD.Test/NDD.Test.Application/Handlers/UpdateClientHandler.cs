using AutoMapper;
using MediatR;
using NDD.Test.Application.Commands.Requests;
using NDD.Test.Domain.Entities;
using NDD.Test.Domain.Interfaces.Repository;

namespace NDD.Test.Application.Handlers
{
    public class UpdateClientHandler : IRequestHandler<UpdateClientRequest>
    {
        private readonly IClientRepository _clientRepository;
        public UpdateClientHandler(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<Unit> Handle(UpdateClientRequest request, CancellationToken cancellationToken)
        {
            var client = await _clientRepository.GetById(request.Id);

            if (client == null)
                throw new Exception("Not Found: " + request.Id);

            client.PhoneNumber = string.IsNullOrEmpty(request.PhoneNumber) ? client.PhoneNumber : request.PhoneNumber;
            client.Email = string.IsNullOrEmpty(request.Email) ? client.Email : request.Email;
            client.Observation = string.IsNullOrEmpty(request.Observation) ? client.Observation : request.Observation;

            await _clientRepository.UpdateAsync(client);

            return Unit.Value;
        }
    }
}
