using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_3_Controller_ToView_2.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult Deneme()
        {
            return View("Sayfa");
        }

        public ViewResult Dokuman()
        {
            return View();
        }

        public ViewResult Sayfam()
        {
            return View();
        }
    }
}
// View methodu geriye bir sayfa döner. View içerisinde parametre olarak sayfa adı verilir. Eğer sayfa adı verilmezse methodun adında sayfa döner.
// Genellikle method isimleriyle sayfa isimleri aynı olur.