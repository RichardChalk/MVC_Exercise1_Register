using System.ComponentModel.DataAnnotations;

namespace Register.ViewModels
{
    public class CreateUserViewModel
    {
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }


        [MaxLength(50)]
        [MinLength(2)]
        public string FirstName { get; set; }


        [MaxLength(50)]
        [MinLength(2)]
        public string LastName { get; set; }


        [Required]
        public string Password { get; set; }


        public bool SendMeUpdates { get; set; } = false;
    }
}
