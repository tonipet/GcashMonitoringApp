using GcashMonitoringWeb.Data;
using GcashMonitoringWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace GcashMonitoringWeb.Controllers
{
    public class LoginController : Controller
    {
        private readonly MigrationDBContext migrationDBContext;

        public LoginController(MigrationDBContext migrationDBContext)
        {
            this.migrationDBContext = migrationDBContext;
        }
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
        public async Task<IActionResult> Register(LoginModel info)
        {
            if (ModelState.IsValid)
            {
                var details = new tbl_login
                {
                    FirstName=  info.FirstName, 
                    LastName = info.LastName,
                    MiddleName= info.MiddleName,
                    Emailaddress= info.Emailaddress,   
                    Password=info.Password,
                    Username=info.Username,
                    DateRegister = DateTime.Now
                };
                migrationDBContext.tbl_login.Add(details);
                migrationDBContext.SaveChanges();
                return View();
            }
            return View(info);
        }


    }


}
