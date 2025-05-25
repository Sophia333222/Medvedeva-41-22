using Medvedeva_41_22.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medvedeva_41_22.Models
{
    public class Load
    {
        [Key]
        public int Id { get; set; }

        public int TeacherId { get; set; }

        [ForeignKey("TeacherId")]
        public virtual Teacher Teacher { get; set; }

        public int DisciplineId { get; set; }

        [ForeignKey("DisciplineId")]
        public virtual Discipline Discipline { get; set; }

        public int Hours { get; set; }
    }
}