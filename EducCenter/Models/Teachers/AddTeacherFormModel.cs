using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducCenter.Models.Teachers
{
    public class AddTeacherFormModel
    {
        //kakvo populva usera za 1 teacher - TOVA E MODEL BINDING
        public string Name { get; init; }
        public string PhoneNumber { get; init; }
        public string Email { get; init; }
        public string Password { get; init; }
        //public int ChildId { get; init; }

        //public ICollection<TeacherCourse> Courses
    }
}
