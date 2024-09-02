using Microsoft.AspNetCore.Mvc;

namespace MVCBasic01.Controllers
{
    // class controller contain some addional method like viewbag ,tempdata 
    public class HomeController : Controller
    {
        //contraller than get all called index
        public IActionResult Index()
        {
            //ViewResult result = new ViewResult();
            //No paramaters will return view of the same name of method Index
            return View();
            //will return view of name of AllMovie
            //return View("AllMovie");
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
