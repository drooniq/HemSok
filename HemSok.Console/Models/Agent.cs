using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

/*
Author: Marcus Karlsson, Fredrik Blixt, Emil Waara
*/

namespace HemSok.Console.Models
{
    public class Agent : IdentityUser
    {
        [Required]
        public string FirstName { get; set; } = String.Empty;
        [Required]
        public string LastName { get; set; } = String.Empty;
        public string? Nickname { get; set; }
        public string? ImagePath { get; set; }
        [Required]
        public Agency Agency { get; set; } = new Agency();
        public Agent() { }
    }
}
