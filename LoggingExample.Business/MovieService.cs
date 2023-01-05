using LoggingExample.Domain.Interfaces;
using LoggingExample.Domain.Models;
using Microsoft.Extensions.Logging;

namespace LoggingExample.Business;

public class MovieService : IMovieService
{
    private readonly IRepository<Movie> repository;
    private readonly ILogger logger;

    public MovieService(IRepository<Movie> repository, ILogger<MovieService> logger)
    {
        this.repository=repository;
        this.logger=logger;
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

    public IEnumerable<Movie> GetAll()
    {
        logger.LogInformation("Retrieving all the movies");

        List<Movie> allMovies = repository.GetAll().ToList();

        logger.Log(LogLevel.Debug, $"Found {allMovies.Count} movies");

        return allMovies;
    }
}
