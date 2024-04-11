using NDD.Test.Application.Queries.Responses;
using NDD.Test.Domain.Entities;

namespace NDD.Test.Domain.Interfaces.Repository
{
    public interface IClientRepository
    {
        Task CreateAsync(Client client);
        Task<Client?> GetById(Guid id);
        Task<IEnumerable<Client>> GetAll();
        Task UpdateAsync(Client client);
        Task DeleteAsync(Client client);
    }
}
