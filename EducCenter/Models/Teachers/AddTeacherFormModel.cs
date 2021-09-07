

namespace EducCenter.Models.Teachers
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public class AddTeacherFormModel
    {
        //kakvo populva usera za 1 teacher - TOVA E MODEL BINDING
        [Required]
        public string Name { get; init; }

        [Required]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; init; }

        [Required]
        public string Email { get; init; }

        [Required]
        public string Password { get; init; }

        public int ChildId { get; set; }


        public string[] CourseId1ToMany { get; set; }
        public ICollection<TeacherCourseViewModel> Courses { get; set; }

        public string StudentId { get; set; }
        public ICollection<TeacherStudentViewModel> Students { get; set; }
    }
}
