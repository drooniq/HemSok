using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore;
using System.ComponentModel.DataAnnotations;

/*
Author: Marcus Karlsson, Fredrik Blixt, Emil Waara
*/

namespace HemSokClient.Models
{
    public class Agent : IdentityUser
    {
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
