namespace EducCenter.Models.Courses
{
    using System.Collections.Generic;

    public class AllCoursesViewModel //za serching QUERY
    {
        public IEnumerable<string> Names { get; init; }
        public string Search { get; init; }
        public CourseSorting Sorting { get; init; }

        public IEnumerable<CourseListingViewModel> Courses { get; init; }
    }
}
