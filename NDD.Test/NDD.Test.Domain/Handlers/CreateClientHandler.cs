using NDD.Test.Domain.Commands.Requests;
using NDD.Test.Domain.Commands.Responses;
using NDD.Test.Domain.Entities;
using NDD.Test.Domain.Interfaces.Handler;
using NDD.Test.Domain.Interfaces.Repository;
using NDD.Test.Domain.Interfaces.Services;

namespace NDD.Test.Domain.Handlers
{
    public class CreateClientHandler : ICreateClientHandler
    {
        private readonly IRepository<Client> _repository;
        private readonly IClientService _clientService;

        public CreateClientHandler(IRepository<Client> repository, IClientService clientService)
        {
            _repository = repository;
            _clientService = clientService;
        }

        public CreateClientResponse Handle(CreateClientRequest command)
        {
            var client = new Client(command.Name, command.CPF, command.Gender, command.PhoneNumber, command.Email, command.BirthDate, command.Observation);

            _repository.CreateAsync(client);

            return new CreateClientResponse()
            {
                Id = client.Id,
                Name = client.Name,
                CPF = client.CPF,
                Gender = client.Gender,
                PhoneNumber = client.PhoneNumber,
                Email = client.Email,
                BirthDate = client.BirthDate,
                Observation = client.Observation
            };
        }
    }
}
