using LayerBusiness.Manager;
using LayerDataAccess.EntityFramework;
using LayerEntity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace _2024._06._10.Controllers
{
    public class KategoriController : Controller
    {
        KategoriYoneticisi ky = new KategoriYoneticisi(new EFKategori());
        public IActionResult Kategoriler()
        {
            return View(ky.KategoriGetir());
        }
        public IActionResult AdminKategoriEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AdminKategoriEkle(Kategori kategori)
        {
            ky.KategoriEkle(kategori);
            return RedirectToAction("AdminKategoriListeleme");
        }
        public IActionResult AdminKategoriListeleme()
        {
            if (HttpContext.Session.GetString("AdminKullaniciID") == null)
            {
                return Redirect("~/Kullanici/AdminLogin");
            }
            else
            {
                return View(ky.KategoriGetir());
            }
        }
        public IActionResult AdminKategoriGuncelle(int id)
        {
            return View(ky.KategoriGetir(id));
        }
        [HttpPost]
        public IActionResult AdminKategoriGuncelle(Kategori kategori)
        {
            ky.KategoriGuncelle(kategori);
            return RedirectToAction("AdminKategoriListeleme");
        }
        public IActionResult AdminKategoriDetay(int id)
        {
            return View(ky.KategoriGetir(id));
        }
        public IActionResult AdminKategoriSil(int id)
        {
            return View(ky.KategoriGetir(id));
        }
        [HttpPost]
        public IActionResult AdminKategoriSil(Kategori kategori)
        {
            ky.KategoriSil(kategori);
            return RedirectToAction("AdminKategoriListeleme");
        }


    }
}
