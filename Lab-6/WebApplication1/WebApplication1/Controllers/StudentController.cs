using Microsoft.AspNetCore.Mvc;
using RegistrationApp.Models;

namespace RegistrationApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Student student)
        {
            if (ModelState.IsValid)
            {
                // Logic to save the student would go here
                ViewBag.Message = "Student registered successfully!";
                return View(); // Return the same view with a success message
            }

            return View(student); // Return the view with validation errors
        }
    }
}
