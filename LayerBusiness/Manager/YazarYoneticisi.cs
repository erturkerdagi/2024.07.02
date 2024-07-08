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
    public class YazarYoneticisi : IYazarServis
    {
        IYazarDAL db;
        public YazarYoneticisi(IYazarDAL yazarDAL)
        {
            db = yazarDAL;
        }
        public void YazarEkle(Yazar yazar)
        {
            db.Ekle(yazar);
        }
        public Yazar YazarGetir(int id)
        {
            return db.Getir(id);
        }
        public Yazar YazarGetir(Yazar yazar)
        {
            return db.Getir(yazar);
        }
        public void YazarGuncelle(Yazar yazar)
        {
            db.Guncelle(yazar);
        }
        public List<Yazar> YazarGetir()
        {
            return db.TumunuGetir();
        }
        public void YazarSil(Yazar yazar)
        {
            db.Sil(yazar);
        }
    }
}
