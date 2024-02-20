using CourseRegistrations.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseRegistrations.Controllers
{
    public class InstructorsController : Controller
    {
        public IActionResult Index()
        {
            var instructors = new List<Instructor>
        {
            new Instructor { InstructorId = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", Course = new Course { CourseId = 1, CourseNumber = "CSE101", CourseName = "Computer Science 101", Description = "Introduction to Computer Science" } },
            new Instructor { InstructorId = 2, FirstName = "Jane", LastName = "Doe", Email = "jane.doe@example.com", Course = new Course { CourseId = 2, CourseNumber = "MTH101", CourseName = "Mathematics 101", Description = "Introduction to Mathematics" } }
        };
            return View(instructors);
        }
    }
}
