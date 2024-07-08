using LayerBusiness.Interface;
using LayerDataAccess;
using LayerEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerBusiness.Manager
{
    public class YaziYoneticisi : IYaziServis
    {
        IYaziDAL db;
        IKategoriDAL dbKategori;
        IYazarDAL dbYazar;
        public YaziYoneticisi(IYaziDAL YaziDAL, IKategoriDAL KategoriDAL, IYazarDAL YazarDAL)
        {
            db = YaziDAL;
            dbKategori = KategoriDAL;
            dbYazar = YazarDAL;
        }
        public void YaziEkle(Yazi Yazi)
        {
            db.Ekle(Yazi);
        }
        public Yazi YaziGetir(int id)
        {
            return db.Getir(id);
        }
        public Yazi YaziGetir(Yazi Yazi)
        {
            return db.Getir(Yazi);
        }
        public void YaziGuncelle(Yazi Yazi)
        {
            db.Guncelle(Yazi);
        }
        public List<Yazi> YaziGetir()
        {
            return db.TumunuGetir();
        }
        public void YaziSil(Yazi Yazi)
        {
            db.Sil(Yazi);
        }

        public List<Yazi> YaziGetirYazaraAit(int id)
        {
            var yazilar = db.Getir(y => y.YazarID == id);
            foreach (var yazi in yazilar)
            {
                yazi.Kategori = dbKategori.Getir(yazi.KategoriID);
                yazi.Yazar = dbYazar.Getir(yazi.YazarID);
            }
            return yazilar;
        }

        public List<Yazi> YaziGetirKategoriyeAit(int id)
        {
            var yazilar = db.Getir(y => y.KategoriID == id);
            foreach (var yazi in yazilar)
            {
                yazi.Yazar = dbYazar.Getir(yazi.YazarID);
                yazi.Kategori = dbKategori.Getir(yazi.KategoriID);
            }
            return yazilar;
        }
    }
}
