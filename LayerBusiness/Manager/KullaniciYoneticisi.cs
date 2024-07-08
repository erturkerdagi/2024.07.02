using LayerBusiness.Interface;
using LayerDataAccess;
using LayerEntity.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LayerBusiness.Manager
{
    public class KullaniciYoneticisi : IKullaniciServis
    {
        IKullaniciDAL db;
        public KullaniciYoneticisi(IKullaniciDAL KullaniciDAL)
        {
            db = KullaniciDAL;
        }
        public Kullanicilar KullaniciGetir(Kullanicilar KullaniciParametre)
        {
            var kullaniciDB = db.Getir(k => k.KullaniciAdi == KullaniciParametre.KullaniciAdi && k.Sifre == KullaniciParametre.Sifre && k.AdminMi == true).FirstOrDefault();
            if (kullaniciDB == null)
            {
                return null;
            }
            else
            {
                return kullaniciDB;
            }
        }
    }
}
