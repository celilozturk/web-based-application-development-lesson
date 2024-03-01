using Microsoft.AspNetCore.Mvc;
using SecondMVCApp.Models;
using System.Collections;


namespace SecondMVCApp.Controllers
{
    public class ArabaController : Controller
    {
        public IActionResult Index()
        {            
            
            Araba araba = new Araba();
            araba.Id = 1;
            araba.Marka = "Ford";
            araba.Renk = "Beyaz";
            araba.ModelYili = 2013;
            araba.Model = "Focus";

            Araba araba2 = new Araba();
            araba2.Id = 2;
            araba2.Marka = "BMW";
            araba2.Renk = "Kırmızı";
            araba2.ModelYili = 2020;
            araba2.Model = "Z3";

            Araba araba3 = new Araba();
            araba3.Id = 3;
            araba3.Marka = "Mercedes";
            araba3.Renk = "Siyah";
            araba3.ModelYili = 2022;
            araba3.Model = "C200";

            
            List<Araba> arabalar = new List<Araba>();
            arabalar.Add(araba);
            arabalar.Add(araba2);
            arabalar.Add(araba3);
            //  arabalar.Remove(araba);
            string mesaj = "Mesaj içeriği...";

            
            return View(arabalar);
        }

        public IActionResult VeriAktarimi()
        {
            Araba araba = new Araba();
            araba.Id = 1;
            araba.Marka = "Ford";
            araba.Renk = "Beyaz";
            araba.ModelYili = 2013;
            araba.Model = "Focus";

            Araba araba2 = new Araba();
            araba2.Id = 2;
            araba2.Marka = "BMW";
            araba2.Renk = "Kırmızı";
            araba2.ModelYili = 2020;
            araba2.Model = "Z3";
            string SayfaMesaji = "BU sayfa Controller'dan View'e veri gondermek için kullanılacak!";

            ViewBag.araba2 = araba2;
            ViewBag.sayfaSayisi = 5;
            ViewBag.mesaj = SayfaMesaji;
            ViewBag.mesaj2 = "BU sayfa Controller'dan View'e veri gondermek için kullanılacak!";


            return View(araba);
        }

    }
}
