using Microsoft.AspNetCore.Mvc;

namespace MVCBasic01.Controllers
{

    // if project is mvc we inherit from controller
    // if project is Api we inherit from controllerBase
    // controller have some method for mvc only
    public class MovieController :Controller
    {
        // Action --> Moive/GetMovie --> Route for this function
        public void GetMovie(int id)
        {

        }
        public string Index()
        {
            return "Index";
        }
    }
}
