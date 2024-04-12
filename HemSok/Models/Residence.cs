using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

/*
Author: Marcus Karlsson, Fredrik Blixt, Emil Waara
*/
namespace HemSok.Models
{
    public class Residence
    {
        [Key]
        public int Id { get; set; }
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
        public int? Rooms { get; set; }
        public int? LivingArea { get; set; }
        public int? BiArea { get; set; }
        public int? PlotArea { get; set; }
        public int? MonthlyFee { get; set; }
        public int? OperationCost { get; set; }
        public int? ConstructionYear { get; set; }
        public string? Description { get; set; }
        public List<string>? ImagePaths { get; set; }
    }
}
