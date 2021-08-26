// Authored By Yogesh, File Name : MovieSoundEffects.cs ,Date 26-08-2021

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InfraCore.Models
{
    /// <summary>
    /// Defines the <see cref="MovieSoundEffects" />.
    /// </summary>
    public class MovieSoundEffects
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the SoundEffects.
        /// </summary>
        public string SoundEffects { get; set; }

        public int MovieimdbID { get; set; }
    }
}
