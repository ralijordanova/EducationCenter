
namespace EducCenter.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class StudentCourse
    {
        public int Id { get; set; }

        public int CourseId { get; set; } 
        public virtual Course Course { get; set; }
      
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }

    }
}
