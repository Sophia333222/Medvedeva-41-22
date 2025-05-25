using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Medvedeva_41_22.Models
{
    public class Cafedra
    {
       
        public int CafedraId { get; set; }
        public string CafedraName { get; set; }
        public int Year { get; set; }
        public int? HeadId { get; set; }
        public Teacher? Head { get; set; }
    }
}