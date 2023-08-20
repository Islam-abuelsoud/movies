using System;
using System.ComponentModel.DataAnnotations;

namespace Moves_List.Models
{
    public class Move
    {
        public int Id { get; set; }
        [Required , MaxLength(250)]
        public string Title { get; set; }
        public int Year { get; set; }
        public double Rate { get; set; }
        [Required , MaxLength(2500)]
        public string StoryLine { get; set; }
        [Required]
        public byte[] Poster { get; set; }
        //
        public byte GenreId { get; set; }
        public Genre Genre { get; set; }

    }
}
