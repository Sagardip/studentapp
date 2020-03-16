using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using studentapps.Models;

namespace studentapp.Controllers
{
    public class SubjectsController:Controller
    {
           private readonly AppDbContext dbContext;

        public  SubjectsController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var subject = dbContext.Subjects;
             
            return View(subject);
        }
       [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create([FromForm] Subject subject)
        {
            dbContext.Add(subject);
            dbContext.SaveChanges();
            TempData["message"] = "Successfully Added";

            return RedirectToAction("Index");
        }
    }
}