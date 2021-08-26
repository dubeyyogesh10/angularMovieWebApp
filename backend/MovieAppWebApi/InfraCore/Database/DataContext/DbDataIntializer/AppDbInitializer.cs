// Authored By Yogesh, File Name : AppDbInitializer.cs ,Date 27-08-2021

namespace InfraCore.Database.DataContext.DbDataIntializer
{
    using InfraCore.Models;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.Extensions.DependencyInjection;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="AppDbInitializer" />.
    /// </summary>
    public class AppDbInitializer
    {
        /// <summary>
        /// The Seed.
        /// </summary>
        /// <param name="applicationBuilder">The applicationBuilder<see cref="IApplicationBuilder"/>.</param>
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<DataContext>();

                if (!context.Movie.Any())
                {

                    var movieList = AppDbInitializer.LoadJson();
                    context.Movie.AddRange(movieList);
                    context.SaveChanges();
                }
            }
        }

        /// <summary>
        /// The LoadJson.
        /// </summary>
        /// <returns>The <see cref="List{Movie}"/>.</returns>
        public static List<Movie> LoadJson()
        {
            List<Movie> movieList = new List<Movie>();
            using (StreamReader r = new StreamReader("file.json"))
            {
                string json = r.ReadToEnd();
                movieList = JsonConvert.DeserializeObject<List<Movie>>(json);
            }

            return movieList;
        }
    }
}
