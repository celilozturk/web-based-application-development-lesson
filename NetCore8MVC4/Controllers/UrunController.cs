using Microsoft.AspNetCore.Mvc;
using NetCore8MVC4.Models;

namespace NetCore8MVC4.Controllers
{
    public class UrunController : Controller
    {
        public IActionResult Index()
        {

          //  List<Urun> urunler = UrunDb.UrunListesi();
            var urunler = UrunDb.UrunListesi();

            return View(urunler);
        }
        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ekle(Urun urun)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var urunler=UrunDb.UrunListesi();   
            urunler.Add(urun);
            return View("Index", urunler);
        }

        public IActionResult Guncelle()
        {
            // return View();
            return Content("Urun guncelle sayfası");
        }
        public IActionResult Sil(int id)
        {
            var urunler = UrunDb.UrunListesi();
            urunler.RemoveAt(id);
            //return View();

            return Content("Urun silindi");

        }
    }
}
