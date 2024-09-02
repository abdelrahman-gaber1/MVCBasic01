using Microsoft.AspNetCore.Mvc;

namespace MVCBasic01.Controllers
{
    public class AccountContraller : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}
