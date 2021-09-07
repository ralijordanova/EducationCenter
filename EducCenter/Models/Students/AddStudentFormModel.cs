
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
        [Display(Name = "Courses")]
        public string[] CourseId1ToMany { get; set; }
        public ICollection<StudentCourseViewModel> Courses { get; set; }

             
    }
}
