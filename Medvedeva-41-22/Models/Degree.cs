using System.ComponentModel.DataAnnotations;

namespace Medvedeva_41_22.Models
{
    public class Degree
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}