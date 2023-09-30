using Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class DemoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return RedirectToAction("Index3", "demo");
        }
        [HttpGet]
        public IActionResult Index2()
        {
            String[] fruits = { "Apple", "Banana", "Orange" };
            return Json(fruits);
        }
        [HttpGet]
        public IActionResult Index3(int a,int b)
        {
            int c = a + b;
            return Content("Sum=" + c);
        }
        [HttpGet]
        public IActionResult StudentForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult StudentForm(StudentModel studentModel)
        {
            return Content("You have submitted "+studentModel.rollno+" and "+ studentModel.name);
        }
    }
}
