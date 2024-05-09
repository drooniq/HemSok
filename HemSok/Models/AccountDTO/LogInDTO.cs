using System.ComponentModel.DataAnnotations;

namespace HemSok.Models.AccountDTO
{
    /*
 Author: Marcus Karlsson, Emil Waara
 */
    public class LogInDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
