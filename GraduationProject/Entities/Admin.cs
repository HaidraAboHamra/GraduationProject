using System.ComponentModel.DataAnnotations;

namespace GraduationProject.Entities
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string PhoneNumber { get; set; }
    }
}
