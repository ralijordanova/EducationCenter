

namespace EducCenter.Models.Teachers
{
    using System.ComponentModel.DataAnnotations;
    
    public class AddTeacherFormModel
    {
        //kakvo populva usera za 1 teacher - TOVA E MODEL BINDING
        public string Name { get; init; }

        [Display(Name = "Phone number")]
        public string PhoneNumber { get; init; }
        public string Email { get; init; }
        public string Password { get; init; }

        //public int ChildId { get; init; }

        //public ICollection<TeacherCourse> Courses
    }
}
