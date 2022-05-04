using System.ComponentModel.DataAnnotations;

namespace CFilzenMain.Models
{
    public class PersonModel
    {
        [Required, StringLength(25, ErrorMessage = "First Name too long (25 character limit).")]
        [DataType(DataType.Text)]
        public string? FirstName { get; set; }

        [Required, StringLength(25, ErrorMessage = "Last Name too long (25 character limit).")]
        [DataType(DataType.Text)]
        public string? LastName { get; set; }

        [Required,StringLength(100,ErrorMessage = "Email Address too long (100 character limit).")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [StringLength(1500 , ErrorMessage = "You have a lot to say. I can only catch 1500 characters.")]
        [DataType(DataType.MultilineText)]
        public string Comment { get; set; }
    }
}
