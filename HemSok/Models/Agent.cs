using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

/*
Author: Marcus Karlsson, Fredrik Blixt, Emil Waara
*/
namespace HemSok.Models
{

    public class Agent : IdentityUser
    {
        private const string DefaultAgentImagePath = "images/ghost1.png";

        [Required]
        public string FirstName { get; set; } = String.Empty;
        [Required]
        public string LastName { get; set; } = String.Empty;
        public string? Nickname { get; set; }

        private string? imagePath = DefaultAgentImagePath;
        public string? ImagePath
        {
            get => string.IsNullOrEmpty(imagePath) ? DefaultAgentImagePath : imagePath;
            set => imagePath = value;
        }
        public Agency? Agency { get; set; }
        public Agent() { }
    }
}
