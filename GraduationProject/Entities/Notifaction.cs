using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GraduationProject.Entities
{
    public class Notifaction
    {
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime DateTime { get; set; }
        public int AdminId { get; set; }
        public int CollegeId { get; set; }


        //Navigation
        [ForeignKey("AdminId")]
        public Admin Admin { get; set; }
        [ForeignKey("CollegeId")]
        public College College { get; set; }
    }
}
