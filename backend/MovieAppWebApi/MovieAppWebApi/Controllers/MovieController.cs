// Authored By Yogesh, File Name : MovieController.cs ,Date 26-08-2021

namespace MovieAppWebApi.Controllers
{
    using InfraCore.Models;
    using Microsoft.AspNetCore.Mvc;
    using MovieAppWebApi.Service;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="MovieController" />.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        /// <summary>
        /// Defines the service.
        /// </summary>
        private readonly IMovieService service;

        /// <summary>
        /// Initializes a new instance of the <see cref="MovieController"/> class.
        /// </summary>
        /// <param name="service">The service<see cref="IMovieService"/>.</param>
        public MovieController(IMovieService service)
        {
            this.service = service;
        }

        /// <summary>
        /// The Get.
        /// </summary>
        /// <returns>The <see cref="Task{ActionResult{List{Movie}}}"/>.</returns>
        [HttpGet]
        public async Task<ActionResult<List<Movie>>> Get()
        {
            return Ok(await this.service.GetMovies().ConfigureAwait(false));
        }

        /// <summary>
        /// The Get.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="Task{ActionResult{Movie}}"/>.</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Movie>> Get([Required] int id)
        {
            return Ok(await this.service.GetMovieById(id).ConfigureAwait(false));
        }

        /// <summary>
        /// The Post.
        /// </summary>
        /// <param name="movie">The movie<see cref="Movie"/>.</param>
        /// <returns>The <see cref="Task{ActionResult{bool}}"/>.</returns>
        [HttpPost]
        public async Task<ActionResult<bool>> Post([FromBody] Movie movie)
        {
            return Ok(await this.service.AddMovie(movie).ConfigureAwait(false));
        }

        /// <summary>
        /// The Post.
        /// </summary>
        /// <param name="movie">The movie<see cref="Movie"/>.</param>
        /// <returns>The <see cref="Task{ActionResult{bool}}"/>.</returns>
        [HttpPost("multiple")]
        public async Task<ActionResult<bool>> Postmultiple([FromBody] Movie[] movie)
        {
            Task task = null;
            foreach (var item in movie)
            {
                await this.service.AddMovie(item).ConfigureAwait(false);
            }
            return Ok();
        }

        /// <summary>
        /// The Put.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <param name="value">The value<see cref="string"/>.</param>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            //TODO
        }

        /// <summary>
        /// The Delete.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            //TODO
        }
    }
}
