using System.ComponentModel.DataAnnotations;

namespace HemSokClient.Models.LoginModels
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirmation Password is required")]
        public string ConfirmPassword { get; set; }
    }
}
