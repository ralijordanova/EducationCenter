using System.Collections.Generic;

namespace EducCenter.Models.Home
{
    public class IndexViewModel
    {
        public int TotalCourses { get; init; }
        public int TotalUsers { get; init; }
        public int TotalStudents { get; set; }

        public List<CourseIndexViewModel> Courses { get; init; }
        public IEnumerable<CourseIndexViewModel> Users { get; init; }
        public List<StudentIndexViewModel> Students { get; init; }

    }
}
