
namespace EducCenter.Models.Students
{
    using EducCenter.Data.Models;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class AddStudentFormModel
    {
        //kakvo populva usera za 1 student - TOVA E MODEL BINDING
       [Required]
        public string Name { get; init; }

        [Required]
        public string Email { get; init; }

        [Required]
         public string Password { get; init; }

        [Required]
        [Display(Name = "Course")]
        public int CourseId { get; init; }
        public ICollection<StudentCourseViewModel> Courses { get; set; }

        public int TeacherId { get; init; }
        public ICollection<StudentTeacherViewModel> Teachers { get; set; }

    }
}
