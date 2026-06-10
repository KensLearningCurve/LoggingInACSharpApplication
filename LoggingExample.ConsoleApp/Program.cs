using LoggingExample.Business;
using LoggingExample.Domain.Interfaces;
using LoggingExample.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

ServiceCollection services = new();

services.AddDbContext<DataContext>(x => x.UseSqlite("Data Source=logging.db"));

services.AddScoped<IMovieService, MovieService>();
services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

services.AddLogging(configure => configure.AddConsole());

ServiceProvider serviceProvider = services.BuildServiceProvider();

using (var scope = serviceProvider.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<DataContext>();
    dbContext.Database.Migrate();
}

IMovieService movieService = serviceProvider.GetRequiredService<IMovieService>();

Console.WriteLine("First run:");
List<Movie> allMovies = [.. movieService.GetAll()];

foreach (Movie movie in allMovies)
{
    Console.WriteLine(movie.Title);
}

Console.WriteLine();
Console.WriteLine("Press key");
Console.ReadLine();

Console.WriteLine("Second run:");
List<Movie> sortedMovies = [.. movieService.GetAll().OrderBy(x => x.Title)];

foreach (Movie movie in sortedMovies)
{
    Console.WriteLine(movie.Title);
}