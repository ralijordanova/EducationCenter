
namespace EducCenter.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    using static DataConstants;

    public class Student
    {
        public Student()
        {
            this.Courses = new HashSet<StudentCourse>();
        }
       
        public int Id { get; set; }

        [Required]
        [MaxLength(StudentNameMaxLength)]
        public string Name { get; set; }
       
        
        [Required]
        [MaxLength(StudentEmailMaxLength)]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }


        public ICollection<StudentCourse> Courses;

    }
}
