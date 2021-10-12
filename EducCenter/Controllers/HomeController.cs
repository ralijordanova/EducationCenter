namespace EducCenter.Controllers
{
    using EducCenter.Data;
    using EducCenter.Models;
    using EducCenter.Models.Courses;
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
            var courses = this.data
                .Courses
                .OrderByDescending(c => c.Id)
                .Select(c => new CourseListingViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Price = c.Price,
                    StartDate = c.StartDate,
                    EndDate = c.EndDate,
                    ImageUrl = c.ImageUrl,
                    Description = c.Description
                })
                .Take(3)
                .ToList();

            return View(courses);
        }
      
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        
    }
}
