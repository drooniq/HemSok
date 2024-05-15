using System.ComponentModel.DataAnnotations;

/*
Author: Marcus Karlsson, Fredrik Blixt, Emil Waara
*/
namespace HemSok.Models
{
    public class Agency
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = String.Empty;
        public string? Description { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Website { get; set; }
        public string? ImagePath { get; set; } = "https://media.wired.com/photos/593272de5c4fbd732b552b5c/master/w_2240,c_limit/ghostbusters-inline.jpg";
        public Agency() { }
    }
}
