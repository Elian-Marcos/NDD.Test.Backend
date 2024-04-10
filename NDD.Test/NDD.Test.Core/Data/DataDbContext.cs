using Microsoft.EntityFrameworkCore;
using NDD.Test.Domain.Entities;

namespace NDD.Test.Core.Data
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options) { }

        public DbSet<Client> Client { get; set; }
    }
}
