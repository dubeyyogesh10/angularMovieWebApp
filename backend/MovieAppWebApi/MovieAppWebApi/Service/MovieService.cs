// Authored By Yogesh, File Name : MovieService.cs ,Date 26-08-2021

namespace MovieAppWebApi.Service
{
    using InfraCore.Database.DataContext.Interface;
    using InfraCore.Models;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="MovieService" />.
    /// </summary>
    public class MovieService : IMovieService
    {
        private readonly IDbClient dbClient;

        public MovieService(IDbClient dbClient)
        {
            this.dbClient = dbClient;
        }
        /// <summary>
        /// The AddMovie.
        /// </summary>
        /// <param name="movie">The movie<see cref="Movie"/>.</param>
        /// <returns>The <see cref="Task{Movie}"/>.</returns>
        public async Task<bool> AddMovie(Movie movie)
        {
            return await dbClient.AddMovie(movie).ConfigureAwait(false);
        }

        /// <summary>
        /// The GetMovieById.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="Task{Movie}"/>.</returns>
        public async Task<Movie> GetMovieById(int id)
        {
            return await dbClient.GetMovie(id).ConfigureAwait(false);
        }

        /// <summary>
        /// The GetMovies.
        /// </summary>
        /// <returns>The <see cref="Task{List{Movie}}"/>.</returns>
        public async Task<List<Movie>> GetMovies()
        {
            return await dbClient.GetMovies().ConfigureAwait(false);
        }
    }
}
