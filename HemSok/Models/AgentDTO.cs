using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

/*
Author: Marcus Karlsson, Fredrik Blixt, Emil Waara
*/

namespace HemSok.Models
{
    public class AgentDTO
    {
        [Required]
        public string Firstname { get; set; } = String.Empty;
        [Required]
        public string Lastname { get; set; } = String.Empty;
        public string? Nickname { get; set; }
        public string? ImagePath { get; set; }
        [Required]
        public Agency Agency { get; set; } = new Agency();
        [Required]
        public string Email { get; set; } = String.Empty;
        [Required]
        public string Password { get; set; } = String.Empty;
        [Required]
        public string Username { get; set; } = String.Empty;
        public string? Role { get; set; }
    }
}
