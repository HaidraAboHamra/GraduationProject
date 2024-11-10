using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GraduationProject.Entities
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        public string SubjectName { get; set; }
        public string SubjectDescription { get; set; }
        public int CollegeId { get; set; }
        public int ProfessorId { get; set; }



        //Navigation
        [ForeignKey("CollegeId")]
        public College College { get; set; }    
        [ForeignKey("ProfessorId")]
        public Professor Professor { get; set; }
        public List<Lecture> Lectures { get; set; }

    }
}
