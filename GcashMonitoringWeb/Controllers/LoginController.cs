using GcashMonitoringWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace GcashMonitoringWeb.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddRegister(LoginModel info )
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            return View(info);
        }


    }


}
