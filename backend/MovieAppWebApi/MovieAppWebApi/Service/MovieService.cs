// Authored By Yogesh, File Name : MovieService.cs ,Date 26-08-2021

namespace MovieAppWebApi.Service
{
    using InfraCore.Models;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="MovieService" />.
    /// </summary>
    public class MovieService : IMovieService
    {
        /// <summary>
        /// The AddMovie.
        /// </summary>
        /// <param name="movie">The movie<see cref="Movie"/>.</param>
        /// <returns>The <see cref="Task{Movie}"/>.</returns>
        public Task<Movie> AddMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The GetMovieById.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="Task{Movie}"/>.</returns>
        public Task<Movie> GetMovieById(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The GetMovies.
        /// </summary>
        /// <returns>The <see cref="Task{List{Movie}}"/>.</returns>
        public Task<List<Movie>> GetMovies()
        {
            throw new NotImplementedException();
        }
    }
}
