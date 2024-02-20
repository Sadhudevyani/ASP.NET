using CourseRegistrations.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseRegistrations.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            var students = new List<Student>
        {
            new Student { StudentId = 1, FirstName = "Alice", LastName = "Smith", Email = "alice.smith@example.com", PhoneNumber = "123-456-7890" },
            new Student { StudentId = 2, FirstName = "Bob", LastName = "Johnson", Email = "bob.johnson@example.com", PhoneNumber = "234-567-8901" }
        };
            return View(students);
        }
    }
}
