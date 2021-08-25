// Authored By Yogesh, File Name : Movie.cs ,Date 26-08-2021

namespace InfraCore.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Movie" />.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Gets or sets the Language.
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Gets or sets the Location.
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the Plot.
        /// </summary>
        public string Plot { get; set; }

        /// <summary>
        /// Gets or sets the Poster.
        /// </summary>
        public string Poster { get; set; }

        /// <summary>
        /// Gets or sets the SoundEffects.
        /// </summary>
        public List<string> SoundEffects { get; set; }

        /// <summary>
        /// Gets or sets the Stills.
        /// </summary>
        public List<string> Stills { get; set; }

        /// <summary>
        /// Gets or sets the Title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the imdbID.
        /// </summary>
        public string imdbID { get; set; }

        /// <summary>
        /// Gets or sets the listingType.
        /// </summary>
        public string listingType { get; set; }

        /// <summary>
        /// Gets or sets the imdbRating.
        /// </summary>
        public string imdbRating { get; set; }
    }
}
