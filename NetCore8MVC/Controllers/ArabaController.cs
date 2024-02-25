using Microsoft.AspNetCore.Mvc;

namespace NetCore8MVC.Controllers
{
    public class ArabaController : Controller
    {

        public ArabaController()
        {

        }
        public IActionResult Index()
        {
            // Araba nesnesini buraya yaratınız !




            return View();
        }

        // Araştırma: Form ile kullanıcıdan alınacak olan verilerin Ekle Metodu altında karşılanması sağlanacaktır!
         public IActionResult Ekle()
        {
            //Kullanıcının gönderdiği veriler burada karşılanacaktır.



            return View();
        }
    }
}
