using System.ComponentModel.DataAnnotations;

namespace HemSok.Models.AccountDTO
{
    /*
 Author: Marcus Karlsson, Emil Waara
 */
    public class RegisterDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Lastname { get; set; }
        public string? agency { get; set; }

    }
}
