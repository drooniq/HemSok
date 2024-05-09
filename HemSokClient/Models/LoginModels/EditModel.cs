using System.ComponentModel.DataAnnotations;
/*
 Author: Emil Waara
 */

namespace HemSokClient.Models.LoginModels
{
    public class EditModel
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Firstname is required")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Lastname is required")]
        public string Lastname { get; set; }

        public string? Nickname { get; set; }
        public string? ImagePath { get; set; }

        [Required]
        public Agency agency { get; set; }
    }
}
