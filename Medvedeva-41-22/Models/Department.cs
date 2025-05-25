

namespace Medvedeva_41_22.Models
{
    public class Department
    {
        public int Id { get; set; } // Первичный ключ
        public string Name { get; set; } = null!; // Название кафедры

        // Добавляем новое свойство для даты основания
        public DateTime FoundationDate { get; set; }

        // Связь "один-к-одному" с заведующим кафедрой
        public int HeadOfDepartmentId { get; set; }
        public Teacher HeadOfDepartment { get; set; } = null!;

        // Связь "один-ко-многим" с преподавателями
        public ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
    }
}
