using LoggingExample.Domain.Interfaces;
using LoggingExample.Domain.Models;
using Microsoft.Extensions.Logging;

namespace LoggingExample.Business;

public class MovieService(IRepository<Movie> repository) : IMovieService
{
    public void Create(Movie movie)
    {
        repository.Create(movie);
    }

    public void Delete(int id)
    {
        Movie? toDelete = Get(id);

        if (toDelete is null)
            return;

        repository.Delete(toDelete);
    }

    public Movie? Get(int id) => repository.GetAll().FirstOrDefault(x => x.Id == id);

    public IEnumerable<Movie> GetAll()
    {
        logger.LogInformation("Retrieving all the movies");

        List<Movie> allMovies = repository.GetAll().ToList();

        logger.Log(LogLevel.Debug, $"Found {allMovies.Count} movies");

        return allMovies;
    }
}
