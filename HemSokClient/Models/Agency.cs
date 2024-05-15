using System.ComponentModel.DataAnnotations;

/*
Author: Marcus Karlsson, Fredrik Blixt, Emil Waara
*/
namespace HemSokClient.Models
{
    public class Agency
    {
        private const string DefaultAgencyImagePath = "/gif/floatingghost.gif";

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = String.Empty;
        public string? Description { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Website { get; set; }

        private string? imagePath = DefaultAgencyImagePath;

        public string? ImagePath
        {
            get => string.IsNullOrEmpty(imagePath) ? DefaultAgencyImagePath : imagePath;
            set => imagePath = value;
        }
        public Agency() { }
    }
}
