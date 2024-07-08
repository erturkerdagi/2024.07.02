using LayerBusiness.Manager;
using LayerDataAccess.EntityFramework;
using LayerEntity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace _2024._06._10.Controllers
{
    public class KullaniciController : Controller
    {
        KullaniciYoneticisi ky = new KullaniciYoneticisi(new EFKullanici());
        public IActionResult AdminLogin()
        {
            HttpContext.Session.Clear();
            return View();
        }

        [HttpPost]
        public IActionResult AdminLogin(Kullanicilar kulllanici)
        {
            var kullaniciDB = ky.KullaniciGetir(kulllanici);
            if (kullaniciDB != null)
            {
                HttpContext.Session.SetString("AdminKullaniciID", kullaniciDB.KullaniciID.ToString());
                return RedirectToAction("AdminHakkindaListeleme", "Hakkinda");
            }
            else
            {
                return View();
            }
        }
    }
}
