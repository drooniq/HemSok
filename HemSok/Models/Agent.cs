using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

/*
Author: Marcus Karlsson, Fredrik Blixt, Emil Waara
*/

namespace HemSok.Models
{
    public class Agent : IdentityUser
    {
        //public Guid Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string? Nickname { get; set; }
        public string? ImagePath { get; set; }
        [Required]
        public Agency Agency { get; set; }
        public Agent() { }
    }
}
