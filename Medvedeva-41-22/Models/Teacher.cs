using Medvedeva_41_22.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

public class Teacher
{
    [Key]
    public int Id { get; set; }

    [Required]

    public string FirstName { get; set; }

    [Required]

    public string LastName { get; set; }

    public int DegreeId { get; set; }

    [ForeignKey("DegreeId")]
    public virtual Degree Degree { get; set; }

    public int PositionId { get; set; }

    [ForeignKey("PositionId")]
    public virtual Position Position { get; set; }

    public int? DepartmentId { get; set; }

    [ForeignKey("DepartmentId")]
    public virtual Department Department { get; set; }

    public virtual ICollection<Load> Loads { get; set; } = new List<Load>();

  
}