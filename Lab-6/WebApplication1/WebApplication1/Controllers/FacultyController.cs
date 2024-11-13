using Microsoft.AspNetCore.Mvc;
using RegistrationApp.Models;

namespace RegistrationApp.Controllers
{
    public class FacultyController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Faculty faculty)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Faculty Registered Successfully!";
            }
            return View();
        }
    }
}
