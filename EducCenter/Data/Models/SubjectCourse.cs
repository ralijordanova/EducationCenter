using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducCenter.Data.Models
{
    public class SubjectCourse
    {
        public int Id { get; init; }

        public int SubjectId { get; set; }
        public Subject Subject { get; set; }


        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
