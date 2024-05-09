using System.ComponentModel.DataAnnotations;

/*
Author: Marcus Karlsson, Fredrik Blixt, Emil Waara
*/
namespace HemSok.Models
{
    public class ResidenceDTO
    {
        [Required]
        public Category Category { get; set; } = new Category();
        [Required]
        public string StreetName { get; set; } = String.Empty;
        [Required]
        public string City { get; set; } = String.Empty;
        [Required]
        public string ZipCode { get; set; } = String.Empty;
        [Required]
        public Municipality Municipality { get; set; } = new Municipality();
        [Required]
        public Agent Agent { get; set; } = new Agent();
        [Required]
        public int ListingPrice { get; set; }
    }
}
