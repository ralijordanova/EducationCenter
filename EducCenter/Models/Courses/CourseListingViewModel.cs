
namespace EducCenter.Models.Courses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class CourseListingViewModel
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public decimal Price { get; init; }
        public DateTime StartDate { get; init; }
        public DateTime EndDate { get; init; }
        public string ImageUrl { get; init; }
        public string Description { get; init; }

    }
}
