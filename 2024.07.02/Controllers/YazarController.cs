using LayerBusiness.Manager;
using LayerDataAccess.EntityFramework;
using LayerEntity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace _2024._06._10.Controllers
{
    public class YazarController : Controller
    {
        YazarYoneticisi yy = new YazarYoneticisi(new EFYazar());
        public IActionResult Yazarlar()
        {
            return View(yy.YazarGetir());
        }
        public IActionResult AdminYazarListeleme()
        {
            if (HttpContext.Session.GetString("AdminKullaniciID") == null)
            {
                return Redirect("~/Kullanici/AdminLogin");
            }
            else
            {
                return View(yy.YazarGetir());
            }
        }
        public IActionResult AdminYazarEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AdminYazarEkle(Yazar yazar)
        {
            yy.YazarEkle(yazar);
            return RedirectToAction("AdminYazarListeleme");
        }
        public IActionResult AdminYazarGuncelle(int id)
        {
            return View(yy.YazarGetir(id));
        }
        [HttpPost]
        public IActionResult AdminYazarGuncelle(Yazar yazar)
        {
            yy.YazarGuncelle(yazar);
            return RedirectToAction("AdminYazarListeleme");
        }
        public IActionResult AdminYazarSil(int id)
        {
            return View(yy.YazarGetir(id));
        }
        [HttpPost]
        public IActionResult AdminYazarSil(Yazar yazar)
        {
            yy.YazarSil(yazar);
            return RedirectToAction("AdminYazarListeleme");
        }
        public IActionResult AdminYazarDetay(int id)
        {
            return View(yy.YazarGetir(id));
        }


    }
}
