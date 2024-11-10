using System.ComponentModel.DataAnnotations;

namespace GraduationProject.Entities
{
    public class Professor
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string PhoneNumber { get; set; }
        public string PasswordHash { get; set; }


        //Navigation
        public List<Subject> Subjects { get; set; }
    }
}
