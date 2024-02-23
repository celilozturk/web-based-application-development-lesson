using Microsoft.AspNetCore.Mvc;

namespace NetCore8MVC.Controllers
{
    public class CarController : Controller
    {

        
        public IActionResult Index()
        {
            return View();
        }
    }
}
