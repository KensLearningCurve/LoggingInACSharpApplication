namespace LoggingExample.Domain.Interfaces;

public interface IRepository<T> where T : class
{
    IQueryable<T> GetAll();
    void Delete(T entity);
    void Create(T entity);
}
