// Authored By Yogesh, File Name : DataContext.cs ,Date 26-08-2021

namespace InfraCore.Database.DataContext
{
    using InfraCore.Models;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Defines the <see cref="DataContext" />.
    /// </summary>
    public class DataContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataContext"/> class.
        /// </summary>
        /// <param name="options">The options<see cref="DbContextOptions"/>.</param>
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the Movie.
        /// </summary>
        public DbSet<Movie> Movie { get; set; }
    }
}
