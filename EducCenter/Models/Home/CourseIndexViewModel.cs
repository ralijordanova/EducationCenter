
namespace EducCenter.Models.Home
{
    using System;

    public class CourseIndexViewModel
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public decimal Price { get; init; }
        public DateTime StartDate { get; init; }
        public DateTime EndDate { get; init; }
        public string ImageUrl { get; init; }
    }
}
