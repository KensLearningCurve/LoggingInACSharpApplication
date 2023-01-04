using LoggingExample.Domain.Interfaces;
using LoggingExample.Domain.Models;

namespace LoggingExample.Business;

public class MovieService : IMovieService
{
    private readonly IRepository<Movie> repository;

    public MovieService(IRepository<Movie> repository)
    {
        this.repository=repository;
    }

    public void Create(Movie movie)
    {
        repository.Create(movie);
    }

    public void Delete(int id)
    {
        Movie? toDelete = Get(id);

        if (toDelete == null)
            return;

        repository.Delete(toDelete);
    }

    public Movie? Get(int id) => repository.GetAll().FirstOrDefault(x => x.Id == id);

    public IEnumerable<Movie> GetAll() => repository.GetAll().ToList();
}
