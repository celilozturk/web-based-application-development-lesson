using Microsoft.AspNetCore.Mvc;
using NetCore8MVC3.Models;

namespace NetCore8MVC3.Controllers
{
    public class MeyveController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag.mesaj = "Bu mesaj Controllerdan View'e aktarılmıştır";
           // List<Meyve> Meyveler = new List<Meyve>();


            //Meyve meyve1 = new Meyve();
            //meyve1.Id = 1;
            //meyve1.Ad = "Şeftali";
            //meyve1.Stok = 100;
            //Meyveler.Add(meyve1);

            List<Meyve> Meyveler = new List<Meyve>()
            {
                new Meyve(){Id=1,Ad="Elma",Stok=200},
                new Meyve(){Id=2,Ad="Armut",Stok=300},
                new Meyve(){Id=3,Ad="Erik",Stok=100},
                new Meyve(){Id=4,Ad="Muz",Stok=150},
                new Meyve(){Id=5,Ad="Çilek",Stok=250},
                new Meyve(){Id=6,Ad="Mango",Stok=80},
                new Meyve(){Id=7,Ad="Üzüm",Stok=120}
            };
       

            return View(Meyveler);
        }

      
    }
}
