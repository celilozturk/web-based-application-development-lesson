using Microsoft.AspNetCore.Mvc;
using NetCore8MVC4.Models;

namespace NetCore8MVC4.Controllers
{
    public class ArabaController : Controller
    {
        public IActionResult Index()
        {

           List<Araba> arabalistesi= ArabaDb.ArabaListesi();          

           return View(arabalistesi);
        }

        public IActionResult Guncelle()
        {

            return View();
        }

        public IActionResult Sil()
        {
            return View();

        }
        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ekle(Araba araba)
        {
            return Content($"Marka:{araba.Marka} Model: {araba.Model} Yıl:{araba.Yil} Renk: {araba.Renk}");
           // return Content("Marka: "+araba.Marka+"Model:"+araba.Model+"Yıl:"+araba.Yil);
        }

    }






    
}
