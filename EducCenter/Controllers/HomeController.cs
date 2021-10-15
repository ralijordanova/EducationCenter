namespace EducCenter.Controllers
{
    using EducCenter.Data;
    using EducCenter.Models;
    using EducCenter.Models.Courses;
    using EducCenter.Models.Home;
    using Microsoft.AspNetCore.Mvc;
    using System.Diagnostics;
    using System.Linq;

    public class HomeController : Controller
    {
        private readonly EducCenterDbContext data;
        public HomeController(EducCenterDbContext data)
        {
            this.data = data;
        }

        public IActionResult Index()
        {
            var TotalCourses = this.data.Courses.Count();
            var TotalStudents = this.data.Students.Count();

            var courses = this.data
                .Courses
                .OrderByDescending(c => c.Id)
                .Select(c => new CourseIndexViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Price = c.Price,
                    StartDate = c.StartDate,
                    EndDate = c.EndDate,
                    ImageUrl = c.ImageUrl
                })
                .Take(3)
                .ToList();

            var students = this.data
                .Students
                .OrderByDescending(s => s.Id)
                .Select(c => new StudentIndexViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Email = c.Email,
                    Password = c.Password
                })
                .Take(3)
                .ToList();

            return View(new IndexViewModel
            {
                TotalCourses = TotalCourses,
                Courses = courses,
                TotalStudents = TotalStudents,
                Students = students,
            });
        }
      
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        
    }
}
