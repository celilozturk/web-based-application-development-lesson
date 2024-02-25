using Microsoft.AspNetCore.Mvc;
using NetCore8MVC.Models;



namespace NetCore8MVC.Controllers
{
    public class UrunController : Controller
    {
        //Constructor kısayol => ctor
        public UrunController()
        {

        }

        public IActionResult Index()
        {
            //Urun nesnesi !
            Urun urun1 = new Urun(); // Nesne yaratma
            urun1.UrunAdi = "Lenovo Thinkpad E14gen5"; // Oluşturulan nesnenin özelliklerine değer ataması yapılması.
            urun1.Fiyat = 7999;
            urun1.UrunStokAdedi = 80;


            return View(urun1);  //  urun1 adındaki nesnenin UrunController'dan View'e aktarılması.
        }
        
        public IActionResult Ekle()
        {
            return View();
        }
    }
}
