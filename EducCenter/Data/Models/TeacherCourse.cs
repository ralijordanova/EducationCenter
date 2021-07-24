
namespace EducCenter.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Threading.Tasks;
    using static DataConstants;

    public class TeacherCourse
    {
        public int Id { get; set; }
    
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }

        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }

        
    }
}
