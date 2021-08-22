
namespace EducCenter.Controllers
{
    using EducCenter.Data;
    using EducCenter.Data.Models;
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
            Subjects = this.GetCourseSubjects(),
            Teachers = this.GetCourseTeachers()
        });

        [HttpPost]
        public IActionResult Add(AddCourseFormModel course)
        {
            
            if (!ModelState.IsValid)
            {
                course.Subjects = this.GetCourseSubjects();
                course.Teachers = this.GetCourseTeachers();
                return View(course);
            }
            var courseData = new Course
            {
                Name = course.Name,
                Price = course.Price,
                StartDate = course.StartDate,
                EndDate = course.EndDate
                
            };
            this.data.Courses.Add(courseData);
            this.data.SaveChanges();

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
        private ICollection<CourseTeacherViewModel> GetCourseTeachers() => this.data
                    .Teachers
                    .Select(s => new CourseTeacherViewModel
                    {
                        Id = s.Id,
                        Name = s.Name
                    })
                    .ToList();


    }
}
