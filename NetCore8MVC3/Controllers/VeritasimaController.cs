using Microsoft.AspNetCore.Mvc;

namespace NetCore8MVC3.Controllers
{
    public class VeritasimaController : Controller
    {
        public IActionResult Index()
        {
            //Model ile veri gonderme
            //Viewdata
            //Tempdata
            //ViewBag
            
            ViewData["mesaj"] = "Bu mesaj viewData ile tasındı!";
            TempData["mesaj5"] = "Bu mesaj tempData ile tasındı!";
            TempData.Keep();
            return View();
        }

        public IActionResult DigerSayfa()
        {
           
            // return  RedirectToAction("Index");
            return View();
        }
    }
}
