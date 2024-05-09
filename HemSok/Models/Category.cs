using System.ComponentModel.DataAnnotations;

/*
Author: Marcus Karlsson, Fredrik Blixt, Emil Waara
*/
namespace HemSok.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = String.Empty;
    }
}
