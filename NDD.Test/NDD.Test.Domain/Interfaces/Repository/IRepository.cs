namespace NDD.Test.Domain.Interfaces.Repository
{
    public interface IRepository<T> where T : class
    {
        Task CreateAsync(T entity);
    }
}
