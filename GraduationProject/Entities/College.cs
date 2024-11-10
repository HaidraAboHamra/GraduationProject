using System.ComponentModel.DataAnnotations;

namespace GraduationProject.Entities
{
    public class College
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int AcademicYear { get; set; }
        
        
        
        //Navigation
        public List<Student> Students { get; set; }
        public List<Subject> Subjects { get; set; }
    }
}
