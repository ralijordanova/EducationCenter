
namespace EducCenter.Controllers
{
    using EducCenter.Models.Teachers;
    using Microsoft.AspNetCore.Mvc;

    public class TeachersController : Controller
    {
        [HttpGet]
        public IActionResult Add() => View();

        [HttpPost]
        public IActionResult Add(AddTeacherFormModel teacher)
        {
            return View();
        }

    }
}
