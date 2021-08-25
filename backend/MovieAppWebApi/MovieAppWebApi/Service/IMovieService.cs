// Authored By Yogesh, File Name : IMovieService.cs ,Date 26-08-2021

namespace MovieAppWebApi.Service
{
    using InfraCore.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="IMovieService" />.
    /// </summary>
    interface IMovieService
    {
        /// <summary>
        /// The GetMovieById.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="Task{Movie}"/>.</returns>
        Task<Movie> GetMovieById(int id);

        /// <summary>
        /// The GetMovies.
        /// </summary>
        /// <returns>The <see cref="Task{List{Movie}}"/>.</returns>
        Task<List<Movie>> GetMovies();

        /// <summary>
        /// The AddMovie.
        /// </summary>
        /// <param name="movie">The movie<see cref="Movie"/>.</param>
        /// <returns>The <see cref="Task{Movie}"/>.</returns>
        Task<Movie> AddMovie(Movie movie);
    }
}
