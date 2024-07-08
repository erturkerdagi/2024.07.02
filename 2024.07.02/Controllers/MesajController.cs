using LayerBusiness.Kurallar;
using LayerBusiness.Manager;
using LayerDataAccess.EntityFramework;
using LayerEntity.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;

namespace _2024._06._10.Controllers
{
    public class MesajController : Controller
    {
        MesajYoneticisi my = new MesajYoneticisi(new EFMesaj());

        public IActionResult MesajGonder()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MesajGonder(Mesaj mesaj)
        {
            MesajKurali mk = new MesajKurali();
            FluentValidation.Results.ValidationResult sonuclar = mk.Validate(mesaj);
            if (sonuclar.IsValid)
            {
                mesaj.MesajDurumu = true;
                mesaj.MesajTarihi = DateTime.Now;
                my.MesajEkle(mesaj);
                return View();
            }
            else
            {
                foreach (var hata in sonuclar.Errors)
                {
                    ModelState.AddModelError(hata.PropertyName, hata.ErrorMessage);
                }
                return View();
            }
        }

        public IActionResult AdminMesajListeleme()
        {
            if (HttpContext.Session.GetString("AdminKullaniciID") == null)
            {
                return Redirect("~/Kullanici/AdminLogin");
            }
            else
            {
                return View(my.MesajGetir());
            }
        }

        public IActionResult AdminMesajDetay(int id)
        {
            return View(my.MesajGetir(id));
        }
    }
}
