using System.ComponentModel.DataAnnotations;

/*
Author: Marcus Karlsson, Fredrik Blixt, Emil Waara
*/

namespace HemSokClient.Models
{
    public class Municipality
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public County County { get; set; }
    }
}
