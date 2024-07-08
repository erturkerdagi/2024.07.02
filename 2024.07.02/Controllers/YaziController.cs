using LayerBusiness.Manager;
using LayerDataAccess.EntityFramework;
using LayerEntity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace _2024._06._10.Controllers
{
    public class YaziController : Controller
    {
        YaziYoneticisi yy = new YaziYoneticisi(new EFYazi(), new EFKategori(), new EFYazar());
        KategoriYoneticisi ky = new KategoriYoneticisi(new EFKategori());
        YazarYoneticisi yy2 = new YazarYoneticisi(new EFYazar());
        YorumYoneticisi yy3 = new YorumYoneticisi(new EFYorum());

        public IActionResult Yazilar()
        {
            var yazilar = yy.YaziGetir();
            foreach (var yazi in yazilar)
            {
                yazi.Kategori = ky.KategoriGetir(yazi.KategoriID);
                yazi.Yazar = yy2.YazarGetir(yazi.YazarID);
                yazi.Yorumlar = yy3.YaziYorumlariniGetir(yazi.YaziID);
            }
            return View(yazilar);
        }

        public IActionResult YaziDetayi(int id)
        {
            ViewBag.YaziID = id;
            var yazi = yy.YaziGetir(id);
            yazi.OkunmaSayisi += 1;
            yy.YaziGuncelle(yazi);
            ViewBag.YazarID = yazi.YazarID;
            yazi.Yazar = yy2.YazarGetir(yazi.YazarID);
            yazi.Kategori = ky.KategoriGetir(yazi.KategoriID);
            var yorum = new Yorum();
            yorum.YaziID = id;
            var detay = new Tuple<Yazi, Yorum>(yazi, yorum);
            return View(detay);
        }

        public IActionResult AdminYaziEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AdminYaziEkle(Yazi yazi)
        {
            yy.YaziEkle(yazi);
            return RedirectToAction("AdminYaziListeleme");
        }
        public IActionResult AdminYaziListeleme()
        {
            if (HttpContext.Session.GetString("AdminKullaniciID") == null)
            {
                return Redirect("~/Kullanici/AdminLogin");
            }
            else
            {
                return View(yy.YaziGetir());
            }
        }
        public IActionResult AdminYaziDetay(int id)
        {
            return View(yy.YaziGetir(id));
        }
        [HttpPost]
        public IActionResult AdminYaziDetay(Yazi yazi)
        {
            yy.YaziGuncelle(yazi);
            return RedirectToAction("AdminYaziListeleme");
        }
        public IActionResult AdminYaziSil(int id)
        {
            return View(yy.YaziGetir(id));
        }
        [HttpPost]
        public IActionResult AdminYaziSil(Yazi yazi)
        {
            yy.YaziSil(yazi);
            return RedirectToAction("AdminYaziListeleme");
        }
        public IActionResult AdminYaziGuncelle(int id)
        {
            return View(yy.YaziGetir(id));
        }
        [HttpPost]
        public IActionResult AdminYaziGuncelle(Yazi yazi)
        {
            yy.YaziGuncelle(yazi);
            return RedirectToAction("AdminYaziListeleme");
        }
        [HttpPost]
        public IActionResult YorumEkle(Yorum yorum)
        {
            yorum.YorumDurumu = true;
            YorumYoneticisi yy = new YorumYoneticisi(new EFYorum());
            yy.YorumEkle(yorum);
            return Redirect("YaziDetayi/" + yorum.YaziID.ToString());
        }

        public IActionResult KategoriYazilari(int id)
        {
            var yazilar = yy.YaziGetirKategoriyeAit(id);
            return View(yazilar);
        }

        public IActionResult SonYazilar()
        {
            var yazilar = yy.YaziGetir();
            foreach (var yazi in yazilar)
            {
                yazi.Kategori = ky.KategoriGetir(yazi.KategoriID);
                yazi.Yazar = yy2.YazarGetir(yazi.YazarID);
                yazi.Yorumlar = yy3.YaziYorumlariniGetir(yazi.YaziID);
            }
            return View(yazilar.Take(3).OrderByDescending(y => y.EklenmeTarihi).ToList());
        }

        public IActionResult EnCokYorumlananYazilar()
        {
            var yazilar = yy.YaziGetir();
            foreach (var yazi in yazilar)
            {
                yazi.Kategori = ky.KategoriGetir(yazi.KategoriID);
                yazi.Yazar = yy2.YazarGetir(yazi.YazarID);
                yazi.Yorumlar = yy3.YaziYorumlariniGetir(yazi.YaziID);
            }
            var yazilar2 = yazilar.OrderByDescending(y => y.Yorumlar.Count);
            return View(yazilar2.Take(3).ToList());
        }

        public IActionResult EnCokOkunanYazilar()
        {
            var yazilar = yy.YaziGetir();
            foreach (var yazi in yazilar)
            {
                yazi.Kategori = ky.KategoriGetir(yazi.KategoriID);
                yazi.Yazar = yy2.YazarGetir(yazi.YazarID);
                yazi.Yorumlar = yy3.YaziYorumlariniGetir(yazi.YaziID);
            }
            var yazilar2 = yazilar.OrderByDescending(y => y.OkunmaSayisi).Take(3).ToList();
            return View(yazilar2);
        }
    }
}
