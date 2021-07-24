
namespace EducCenter.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static DataConstants;

    public class Teacher 
    {
        public Teacher()
        {
            this.Courses = new HashSet<TeacherCourse>();
            this.Subjects = new HashSet<Subject>();

        }       
        public int Id { get; set; }

        [Required]
        [MaxLength(TeacherNameMaxLength)]
        public string Name { get; set; }
       

        [Required]
        [MaxLength(TeacherPhoneMaxLength)]
        public string PhoneNumber { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }


        public ICollection<Subject> Subjects { get; set; }

        public ICollection<TeacherCourse> Courses { get; set; }

    }
}
