

using EducCenter.Data.Models;
using System.Collections.Generic;

namespace EducCenter.Models.Students
{

    public class AddStudentFormModel
    {
        //kakvo populva usera za 1 student - TOVA E MODEL BINDING
       
        public string Name { get; init; }
        public string Email { get; init; }
         public string Password { get; init; }


        public ICollection<StudentCourse> Courses { get; set; }
        
     }
}
