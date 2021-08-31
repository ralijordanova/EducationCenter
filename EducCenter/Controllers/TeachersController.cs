
namespace EducCenter.Controllers
{
    using EducCenter.Data;
    using EducCenter.Data.Models;
    using EducCenter.Models.Teachers;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TeachersController : Controller
    {
        private readonly EducCenterDbContext data;
        public TeachersController(EducCenterDbContext data)
        {
            this.data = data;
        }
        [HttpGet]
        public IActionResult Add() => View(new AddTeacherFormModel
        {
            Courses = this.GetTeacherCourse()
        });

        [HttpPost]
        public IActionResult Add(AddTeacherFormModel teacher)
        {
            //if (!this.data.Courses.Any(c => c.Id == teacher.CourseId1ToMany))
            //{
            //    this.ModelState.AddModelError(nameof(course.SubjectId), "Subject does not exsist");
            //}

            if (!ModelState.IsValid)
            {
                teacher.Courses = this.GetTeacherCourse();
                return View(teacher);
            }
            var teacherData = new Teacher
            {
                Name = teacher.Name,
                PhoneNumber = teacher.PhoneNumber,
                Email = teacher.Email,
                Password = teacher.Password,
                Courses = teacher.CourseId1ToMany.Select(s => new TeacherCourse
                {                   
                    CourseId = Convert.ToInt32(s)
                }).ToList()
            };
            
            
            this.data.Teachers.Add(teacherData);
            this.data.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        private ICollection<TeacherCourseViewModel> GetTeacherCourse() => this.data
            .Courses
            .Select(s => new TeacherCourseViewModel
            {
                Id = s.Id,
                Name = s.Name
            })
            .ToList();

    }
}
