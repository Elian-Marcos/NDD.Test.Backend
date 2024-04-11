using Microsoft.EntityFrameworkCore;
using NDD.Test.Core.Data;
using NDD.Test.Domain.Entities;
using NDD.Test.Domain.Interfaces.Repository;

namespace NDD.Test.Core.Repository
{
    public class ClientRepository : IClientRepository
    {
        private readonly DataDbContext _dataDbContext;
        public ClientRepository(DataDbContext dataDbContext)
        {
            _dataDbContext = dataDbContext;
        }

        public async Task CreateAsync(Client client)
        {
            await _dataDbContext.AddAsync(client);
            await _dataDbContext.SaveChangesAsync();
        }

        public async Task<Client?> GetById(Guid id)
        {
            return await _dataDbContext.Client.FindAsync(id);
        }

        public async Task<List<Client>> GetAll()
        {
            return await _dataDbContext.Client.ToListAsync();
        }

        public async Task UpdateAsync(Client client)
        {
            _dataDbContext.Entry(client).State = EntityState.Modified;
            await _dataDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Client client)
        {
            _dataDbContext.Client.Remove(client);
            await _dataDbContext.SaveChangesAsync();
        }

    }
}
