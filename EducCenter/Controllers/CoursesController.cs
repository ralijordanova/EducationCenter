
namespace EducCenter.Controllers
{
    using EducCenter.Data;
    using EducCenter.Models.Courses;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class CoursesController : Controller
    {
        private readonly EducCenterDbContext data;
        public CoursesController(EducCenterDbContext data)
        {
            this.data = data;
        }

        [HttpGet]//taka view-to ste znae za subject-a
        public IActionResult Add() => View(new AddCourseFormModel
        {
            Subjects = this.GetCourseSubjects()
        });

        [HttpPost]
        public IActionResult Add(AddCourseFormModel course)
        {
            if (!ModelState.IsValid)
            {
                return View(course);
            }
            return RedirectToAction("Index", "Home");
        }
        private IEnumerable<CourseSubjectViewModel> GetCourseSubjects() => this.data
            .Subjects
            .Select(s => new CourseSubjectViewModel
            {
                Id = s.Id,
                Name = s.Name
            })
            .ToList();


         
    }
}
