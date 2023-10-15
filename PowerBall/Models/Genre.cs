using System.ComponentModel.DataAnnotations;

namespace Powerball_Ticket_Generator.Models
{
    public class Genre
    {
        [Key] // This indicates that GenreId is the primary key
        public string? GenreId { get; set; }

        [Required(ErrorMessage = "Please enter the genre name.")]
        public string? Name { get; set; }
    }
}