// Authored By Yogesh, File Name : MovieStills.cs ,Date 26-08-2021

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InfraCore.Models
{
    /// <summary>
    /// Defines the <see cref="MovieStills" />.
    /// </summary>
    public class MovieStills
    {
        public int Id { get; set; }



        /// <summary>
        /// Gets or sets the Stills.
        /// </summary>
        public string Stills { get; set; }

        /// <summary>
        /// Gets or sets the imdbID.
        /// </summary>
        public int MovieimdbID { get; set; }
    }
}
