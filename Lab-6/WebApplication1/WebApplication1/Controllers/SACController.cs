using Microsoft.AspNetCore.Mvc;
using RegistrationApp.Models;

namespace RegistrationApp.Controllers
{
    public class SACController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(SAC sac)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "SAC Registered Successfully!";
            }
            return View();
        }
    }
}
