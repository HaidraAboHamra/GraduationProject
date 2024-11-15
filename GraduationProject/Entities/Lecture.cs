﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GraduationProject.Entities
{
    public class Lecture
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public int CollegeId { get; set; }
        public int SubjectId { get; set; }


        //Navigation
        [ForeignKey("CollegeId")]
        public College College { get; set; }
        [ForeignKey("SubjectId")]
        public Subject Subject { get; set; }
    }
}
