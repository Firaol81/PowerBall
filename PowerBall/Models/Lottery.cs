using System.ComponentModel.DataAnnotations;

namespace Powerball_Ticket_Generator.Models
{
    public class Lottery
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your full name.")]
        public string? FullName { get; set; }

        [Required(ErrorMessage = "Please select your gender.")]
        public string? Gender { get; set; }

        [Required(ErrorMessage = "Please enter your age.")]
        [Range(18, 100, ErrorMessage = "Age must be between 18 and 100.")]
        public int Age { get; set; }

        public string? Location { get; set; }

        [Required(ErrorMessage = "Please enter your Powerball numbers.")]
        [RegularExpression(@"^(\d+\s*)+$", ErrorMessage = "Powerball numbers must be space-separated digits.")]
        public string? PowerballNumbers { get; set; }
    }
}
