using System.ComponentModel.DataAnnotations;

/*
 Author: Marcus Karlsson
 */
namespace HemSok.Models.AccountDTO
{
    public class UserDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        public string? Token { get; set; }
    }
}
