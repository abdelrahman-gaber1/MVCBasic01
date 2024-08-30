using Microsoft.AspNetCore.Mvc;

namespace MVCBasic01.Controllers
{

    // if project is mvc we inherit from controller
    // if project is Api we inherit from controllerBase
    // controller have some method for mvc only
    public class MovieController :Controller
    {
        // Action --> Moive/GetMovie --> Route for this function
        // Action have special return type contentResult
        // to avoid develop againest concreate class we use IActionResult
        // IActionResult interface all special type of action inhert form him
        //develop againest Interface not concreate class
        public IActionResult GetMovie(int id)
        {
            ContentResult result = new ContentResult();
            result.Content = $"Movie with id = {id}";
            result.ContentType = "object/pdf" ;
            result.StatusCode = 200 ;

            return Content($"Movie with id = {id}", "txt/html") ; //helper method only in controller
        }
        // route became Movie/hamada insted of index
        [ActionName("hamada")]
        // to reach to this method http request must be Get
        [HttpGet]
        public IActionResult Index()
        {
            RedirectResult redirectResult = new RedirectResult("https://localhost:44322/Movie/GetMovie");
            //return Redirect("https://localhost:44322/Movie/GetMovie"); //helper method 
            //return RedirectToAction(nameof(GetMovie), new {id = 10});//helper method
            return RedirectToRoute("default"); 
        }
        public IActionResult Hamada()
        {
            return View();
        }
    }
}
