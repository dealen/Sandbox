using System.ComponentModel.DataAnnotations;

namespace BlazorOne.Data
{
    public class FormExampleModel
    {
        [Required]
        [MaxLength(30, ErrorMessage = "Name to long, sorry!")]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(30, ErrorMessage = "Lastname to long, sorry!")]
        public string LastName { get; set; } = string.Empty;

        [Range(1, 150, ErrorMessage = "Please provide proper value form range 1 to 150. I guess infant can't fill it and if you're more than 150 how to hell you're keeping up??")]
        public int Age { get; set; } = 1;
    }
}
