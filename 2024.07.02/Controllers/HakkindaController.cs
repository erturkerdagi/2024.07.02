using LayerBusiness.Manager;
using LayerDataAccess.EntityFramework;
using LayerEntity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace _2024._06._10.Controllers
{
    public class HakkindaController : Controller
    {
        HakkindaYoneticisi hk = new HakkindaYoneticisi(new EFHakkinda());

        public IActionResult Hakkinda()
        {
            var hakkinda = hk.HakkindaGetir();
            return View(hakkinda[0]);
        }

        public IActionResult AdminHakkindaEkle()
        {
            if (HttpContext.Session.GetString("AdminKullaniciID") == null)
            {
                return Redirect("~/Kullanici/AdminLogin");
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult AdminHakkindaEkle(Hakkinda hakkinda)
        {
            hk.HakkindaEkle(hakkinda);
            return RedirectToAction("AdminHakkindaListeleme");
        }

        public IActionResult AdminHakkindaListeleme()
        {
            if (HttpContext.Session.GetString("AdminKullaniciID") == null)
            {
                return Redirect("~/Kullanici/AdminLogin");
            }
            else
            {
                return View(hk.HakkindaGetir());
            }
        }
        public IActionResult AdminHakkindaGuncelle(int id)
        {
            return View(hk.HakkindaGetir(id));
        }

        [HttpPost]
        public IActionResult AdminHakkindaGuncelle(Hakkinda hakkinda)
        {
            hk.HakkindaGuncelle(hakkinda);
            return RedirectToAction("AdminHakkindaListeleme");
        }

        public IActionResult AdminHakkindaSil(int id)
        {
            return View(hk.HakkindaGetir(id));
        }

        [HttpPost]
        public IActionResult AdminHakkindaSil(Hakkinda hakkinda)
        {
            hk.HakkindaSil(hakkinda);
            return RedirectToAction("AdminHakkindaListeleme");
        }

        public IActionResult AdminHakkindaDetay(int id)
        {
            return View(hk.HakkindaGetir(id));
        }
    }
}
