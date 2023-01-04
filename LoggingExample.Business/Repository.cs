using LoggingExample.Domain.Interfaces;

namespace LoggingExample.Business;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly DataContext dataContext;

    public Repository(DataContext dataContext)
    {
        this.dataContext = dataContext;
    }

    public void Create(T entity)
    {
        dataContext.Add(entity);
        dataContext.SaveChanges();
    }

    public void Delete(T entity)
    {
        dataContext.Remove(entity);
        dataContext.SaveChanges();
    }

    public IQueryable<T> GetAll()
    {
        return dataContext.Set<T>();
    }
}
