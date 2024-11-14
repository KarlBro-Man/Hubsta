using System.ComponentModel.DataAnnotations;

namespace Hubsta.ViewModels
{
    public class RegisterVM
    {
        [Required(ErrorMessage = "Please enter first name")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "Please enter last name")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Please enter gender")]
        public string? Gender { get; set; }
        [Required(ErrorMessage = "Please enter email")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Please enter password")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Required(ErrorMessage = "Please enter confirm password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password not same. Please check again")]
        public string? ConfirmPassword { get; set; }
    }
}
