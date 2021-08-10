
namespace EducCenter.Controllers
{
    using EducCenter.Models.Students;
    using Microsoft.AspNetCore.Mvc;

    public class StudentsController: Controller
    {
        [HttpGet]
        public IActionResult Add() => View();

        [HttpPost]
        public IActionResult Add(AddStudentFormModel student)
        {
            return View();
        }


    }
}
