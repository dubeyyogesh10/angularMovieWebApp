// Authored By Yogesh, File Name : IDbClient.cs ,Date 26-08-2021

namespace InfraCore.Database.DataContext.Interface
{
    using InfraCore.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="IDbClient" />.
    /// </summary>
    public interface IDbClient
    {
        /// <summary>
        /// The GetMovies.
        /// </summary>
        /// <returns>The <see cref="List{Movie}"/>.</returns>
        Task<List<Movie>> GetMovies();

        /// <summary>
        /// The AddMovie.
        /// </summary>
        /// <param name="Movie">The Movie<see cref="Movie"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        Task<bool> AddMovie(Movie Movie);

        /// <summary>
        /// The GetMovie.
        /// </summary>
        /// <param name="id">The id<see cref="long"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        Task<Movie> GetMovie(int id);

        /// <summary>
        /// The DeleteMovie.
        /// </summary>
        /// <param name="id">The id<see cref="long"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        Task<bool> DeleteMovie(long id);

        /// <summary>
        /// The UpdateMovie.
        /// </summary>
        /// <param name="Movie">The Movie<see cref="Movie"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        Task<bool> UpdateMovie(Movie Movie);
    }
}
