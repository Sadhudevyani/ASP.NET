using CourseRegistrations.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseRegistrations.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            var courses = new List<Course>
        {
            new Course { CourseId = 1, CourseNumber = "CSE101", CourseName = "Computer Science 101", Description = "Introduction to Computer Science", Students = new List<Student> { new Student { StudentId = 1, FirstName = "Alice", LastName = "Smith", Email = "alice.smith@example.com", PhoneNumber = "123-456-7890" } } },
            new Course { CourseId = 2, CourseNumber = "MTH101", CourseName = "Mathematics 101", Description = "Introduction to Mathematics", Students = new List<Student> { new Student { StudentId = 2, FirstName = "Bob", LastName = "Johnson", Email = "bob.johnson@example.com", PhoneNumber = "234-567-8901" } } }
        };
            return View(courses);
        }
    }
}
