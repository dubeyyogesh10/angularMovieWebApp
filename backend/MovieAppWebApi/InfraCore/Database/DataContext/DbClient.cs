// Authored By Yogesh, File Name : DbClient.cs ,Date 26-08-2021

namespace InfraCore.Database.DataContext
{
    using InfraCore.Database.DataContext.Interface;
    using InfraCore.Models;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="DbClient" />.
    /// </summary>
    public class DbClient : IDbClient
    {
        /// <summary>
        /// Defines the context.
        /// </summary>
        private readonly DataContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="DbClient"/> class.
        /// </summary>
        /// <param name="context">The context<see cref="DataContext"/>.</param>
        public DbClient(DataContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// The AddMovie.
        /// </summary>
        /// <param name="Movie">The Movie<see cref="Movie"/>.</param>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public async Task<bool> AddMovie(Movie Movie)
        {
            await context.Movie.AddAsync(Movie);
            var result = await context.SaveChangesAsync().ConfigureAwait(false);
            return result > 0;
        }

        /// <summary>
        /// The DeleteMovie.
        /// </summary>
        /// <param name="id">The id<see cref="long"/>.</param>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public async Task<bool> DeleteMovie(long id)
        {
            var Movie = await context.Movie.FindAsync(id).ConfigureAwait(false);
            if (Movie != null)
            {
                context.Movie.Remove(Movie);
                var result = await context.SaveChangesAsync().ConfigureAwait(false);
                return result > 0;
            }

            return false;
        }

        /// <summary>
        /// The GetMovie.
        /// </summary>
        /// <param name="id">The id<see cref="long"/>.</param>
        /// <returns>The <see cref="Task{Movie}"/>.</returns>
        public async Task<Movie> GetMovie(int id)
        {
            return await context.Movie.FindAsync(id).ConfigureAwait(false);
        }

        /// <summary>
        /// The GetMovies.
        /// </summary>
        /// <returns>The <see cref="List{Movie}"/>.</returns>
        public async Task<List<Movie>> GetMovies()
        {
            return await context.Movie.ToListAsync().ConfigureAwait(false);
        }

        /// <summary>
        /// The UpdateMovie.
        /// </summary>
        /// <param name="request">The request<see cref="Movie"/>.</param>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public async Task<bool> UpdateMovie(Movie request)
        {
            var existingMovie = await context.Movie.FindAsync(request.imdbID).ConfigureAwait(false);
            if (existingMovie != null)
            {
                existingMovie.Title = request.Title;
                existingMovie.Plot = request.Plot;
                existingMovie.Poster = request.Poster;
                existingMovie.Language = request.Language;
                existingMovie.listingType = request.listingType;
                context.Movie.Update(existingMovie);
                var result = await context.SaveChangesAsync().ConfigureAwait(false);
                return result > 0;
            }

            return false;
        }
    }
}
