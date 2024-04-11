using FluentValidation;
using MediatR;
using NDD.Test.Application.Commands.Requests;
using NDD.Test.Application.Commands.Responses;
using NDD.Test.Domain.Entities;
using NDD.Test.Domain.Interfaces.Repository;

namespace NDD.Test.Domain.Handlers
{
    public class CreateClientHandler : IRequestHandler<CreateClientRequest, CreateClientResponse>
    {
        private readonly IClientRepository _repository;
        private readonly IValidator<Client> _validator;

        public CreateClientHandler(IClientRepository repository, IValidator<Client> validator)
        {
            _repository = repository;
            _validator = validator;
        }

        public async Task<CreateClientResponse> Handle(CreateClientRequest command, CancellationToken cancellation)
        {
            var client = new Client(command.Name, command.CPF, command.Gender, command.PhoneNumber, command.Email, command.BirthDate, command.Observation);

            CreateClientResponse result = new CreateClientResponse();

            if (_validator.Validate(client).IsValid)
            {
                await _repository.CreateAsync(client);

                result = new  CreateClientResponse()
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
            return await Task.FromResult(result);
        }
    }
}
