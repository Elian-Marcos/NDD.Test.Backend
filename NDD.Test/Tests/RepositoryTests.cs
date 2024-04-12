using Microsoft.EntityFrameworkCore;
using NDD.Test.Core.Data;
using NDD.Test.Core.Repository;
using NDD.Test.Domain.Entities;
using NDD.Test.Domain.Interfaces.Repository;

namespace NDD.Test.Core.xUnit.Tests
{
    public class RepositoryTests
    {
        DataDbContext _context;
        private readonly IClientRepository _clientRepository;

        public RepositoryTests()
        {
            var options = new DbContextOptionsBuilder<DataDbContext>()
                 .UseInMemoryDatabase(databaseName: "tests")
                 .Options;
            _context = new DataDbContext(options);
            _clientRepository = new ClientRepository(_context);
        }

        [Fact(DisplayName = "CreateAsync")]
        public async Task TestCreate()
        {
            var client = new Client()
            {
                Name = "John Test",
                CPF = "78365492083",
                Gender = "masculine",
                PhoneNumber = "15988887777",
                Email = "john_test@gmail.com",
                BirthDate = DateTime.Parse("1991-08-07"),
                Observation = "Test Create"
            };

            await _clientRepository.CreateAsync(client);

            var result = await _clientRepository.GetById(client.Id);

            Assert.NotNull(result);
            Assert.Equal(client.Id, result.Id);
        }

        [Fact(DisplayName = "UpdateAsync")]
        public async Task TestUpdate()
        {
            var client = new Client()
            {
                Name = "John Test",
                CPF = "78365492083",
                Gender = "masculine",
                PhoneNumber = "15988887777",
                Email = "john_test@gmail.com",
                BirthDate = DateTime.Parse("1991-08-07"),
                Observation = "Test Create"
            };

            await _clientRepository.CreateAsync(client);

            var result = await _clientRepository.GetById(client.Id);

            var observation = result.Observation;
            var phone = result.PhoneNumber;

            client.PhoneNumber = "11922223333";
            client.Observation = "Update test";

            await _clientRepository.UpdateAsync(client);

            var resultUpdate = await _clientRepository.GetById(client.Id);

            Assert.NotEqual(phone, resultUpdate.PhoneNumber);
            Assert.NotEqual(observation, resultUpdate.Observation);
        }

        [Fact(DisplayName = "Delete")]
        public async Task TestDelete()
        {
            var client = new Client()
            {
                Name = "John Test",
                CPF = "78365492083",
                Gender = "masculine",
                PhoneNumber = "15988887777",
                Email = "john_test@gmail.com",
                BirthDate = DateTime.Parse("1991-08-07"),
                Observation = "Test Delete"
            };

            await _clientRepository.CreateAsync(client);

            var result = await _clientRepository.GetById(client.Id);

            await _clientRepository.DeleteAsync(client);

            var resultBefore = await _clientRepository.GetById(client.Id);

            Assert.Null(resultBefore);
        }
    }
}
