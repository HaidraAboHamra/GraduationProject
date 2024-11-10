using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GraduationProject.Entities
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Enum.Gender Sex { get; set; }
        public int Age { get; set; }
        public DateOnly Birthday { get; set; }
        public int AcadimicYear { get; set; }
        public string ProfileImgPath { get; set; }
        public string CertificateImgPath { get; set; }
        public string IdImgPath { get; set; }
        public string PasswordHash { get; set; }
        public int CollegeId { get; set; }



        //Navigation
        [ForeignKey("CollegeId")]
        public College College { get; set; }
    }
}
