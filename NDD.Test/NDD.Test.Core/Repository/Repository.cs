using NDD.Test.Core.Data;
using NDD.Test.Domain.Interfaces.Repository;

namespace NDD.Test.Core.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DataDbContext _dataDbContext;
        public Repository(DataDbContext dataDbContext)
        {
            _dataDbContext = dataDbContext;
        }

        public async Task CreateAsync(T entity)
        {
            await _dataDbContext.AddAsync(entity);
            await _dataDbContext.SaveChangesAsync();
        }
    }
}
