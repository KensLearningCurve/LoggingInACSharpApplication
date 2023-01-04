using LoggingExample.Domain.Models;

namespace LoggingExample.Domain.Interfaces;

public interface IMovieService
{
    void Create(Movie movie);
    void Delete(int id);
    Movie? Get(int id);
    IEnumerable<Movie> GetAll();
}
