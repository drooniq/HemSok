using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

/*
Author: Marcus Karlsson, Fredrik Blixt, Emil Waara
*/
namespace HemSokClient.Models
{
    public class ResidenceDTO
    {
        [Required]
        public Category Category { get; set; }
        [Required]
        public string StreetName { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string ZipCode { get; set; }
        [Required]
        public Municipality Municipality { get; set; }
        [Required]
        public Agent Agent { get; set; }
        [Required]
        public int ListingPrice { get; set; }
    }
}
