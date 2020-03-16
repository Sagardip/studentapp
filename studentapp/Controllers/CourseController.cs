using System.Linq;
using Microsoft.AspNetCore.Mvc;
using studentapps.Models;

namespace studentapp.Controllers
{
    public class CourseController:Controller
    {
         private readonly AppDbContext dbContext;

        public CourseController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var courses = dbContext.Courses;
            return View(courses);
        }
    }
}