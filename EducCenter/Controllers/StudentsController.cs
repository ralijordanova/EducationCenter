
namespace EducCenter.Controllers
{
    using EducCenter.Data;
    using EducCenter.Data.Models;
    using EducCenter.Models.Students;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentsController : Controller
    {
        private readonly EducCenterDbContext data;
        public StudentsController(EducCenterDbContext data)
        {
            this.data = data;
        }

        [HttpGet]
        public IActionResult Add() => View(new AddStudentFormModel
        {
            Courses = this.GetStudentCourses(),            
        });


        [HttpPost]
        public IActionResult Add(AddStudentFormModel student)
        {
            
            if (!ModelState.IsValid)
            {
                student.Courses = this.GetStudentCourses();             
                return View(student);
            }
            var studentData = new Student
            {
                Name = student.Name,
                Email = student.Email,
                Password = student.Password,
                Courses = student.CourseId1ToMany.Select(s => new StudentCourse
                {
                    CourseId = Convert.ToInt32(s)
                }).ToList(),
                
            };
            this.data.Students.Add(studentData);
            this.data.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        private ICollection<StudentCourseViewModel> GetStudentCourses() => this.data
            .Courses
            .Select(s => new StudentCourseViewModel
            {
                Id = s.Id,
                Name = s.Name
            })
            .ToList();
        private ICollection<StudentTeacherViewModel> GetStudentTeachers() => this.data
            .Teachers
            .Select(t => new StudentTeacherViewModel
            {
                Id = t.Id,
                Name = t.Name
            })
            .ToList();
    }
}
