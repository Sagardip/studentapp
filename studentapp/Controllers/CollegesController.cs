using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using studentapps.Models;

namespace studentapps.Controllers
{
    public class CollegesController : Controller
    {

        private readonly AppDbContext dbContext;

        public CollegesController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var colleges = dbContext.Colleges;
            return View(colleges);
        }
        public IActionResult Details(int id)
        {
            var college = dbContext.Colleges
                            .Include(college => college.Students)
                        .Where(c => c.Id == id).FirstOrDefault();
            return View(college);
        }
        [HttpGet]
        public IActionResult Addcollege()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Addcollege([FromForm] College college)
        {
            dbContext.Add(college);
            dbContext.SaveChanges();
            TempData["message"] = "Successfully Added";

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            var Colleges = dbContext.Colleges.FirstOrDefaultAsync(c => c.Id == id);
            return View();

        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var college = dbContext.Colleges.Find(id);
            dbContext.Colleges.Remove(college);
            dbContext.SaveChanges();
             return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var College = dbContext.Colleges.FirstOrDefault(c => c.Id == id);
            return View(College); 

        }
        [HttpPost]
        public IActionResult Edit([FromForm] College college)
        {
            dbContext.Add(college);
            dbContext.SaveChanges();
            TempData["message"] = "Successfully Added";
             return RedirectToAction("Index");
        }

    }
}