using Demo.Data;
using Demo.Entites;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public StudentController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Student> students = _appDbContext.Set<Student>().ToList();
            //  List<Student> students = _appDbContext.Set<Student>().Where(x => x.Roll < 1000).OrderBy(x => x.Name).ToList();
            return View(students);
        }
        [HttpGet] 
        public IActionResult Add() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Student student)
        {
            _appDbContext.Set<Student>().Add(student);
            _appDbContext.SaveChanges();
            return RedirectToAction("index", "student");
        }
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            Student student = _appDbContext.Set<Student>().Find(id);
            return View(student);
        }
        [HttpPost]
        public IActionResult Edit(Student student)
        {
            _appDbContext.Set<Student>().Update(student);
            _appDbContext.SaveChanges();
            return RedirectToAction("index", "student");
        }
        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            Student student = _appDbContext.Set<Student>().Find(id);
            _appDbContext.Set<Student>().Remove(student);
            _appDbContext.SaveChanges();
            return RedirectToAction("index", "student");
        }
    }
}
