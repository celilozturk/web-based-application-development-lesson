using Microsoft.AspNetCore.Mvc;
using NetCore8MVC3.Models;

namespace NetCore8MVC3.Controllers
{
    public class UrunController : Controller
    {
        //Action Method
        public IActionResult Index()
        {
            Urun urun = new Urun();
            urun.Id= 1;
            urun.Ad = "Dell Aspire";
            urun.Stok = 100;

            return View(urun);
        }

        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ekle(Urun urun)
        {

            return Content("urun basariyla eklendi");
        }

        public IActionResult Guncelle()
        {
            return View();
        }

        public IActionResult Sil()
        {
            return View();
        }


    }
}
