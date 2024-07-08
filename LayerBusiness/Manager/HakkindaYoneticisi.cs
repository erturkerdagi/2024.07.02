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
    public class HakkindaYoneticisi : IHakkindaServis
    {
        IHakkindaDAL db;
        public HakkindaYoneticisi(IHakkindaDAL HakkindaDAL)
        {
            db = HakkindaDAL;
        }
        public void HakkindaEkle(Hakkinda Hakkinda)
        {
            db.Ekle(Hakkinda);
        }
        public Hakkinda HakkindaGetir(int id)
        {
            return db.Getir(id);
        }
        public Hakkinda HakindaGetir(Hakkinda hakkinda)
        {
            return db.Getir(hakkinda);
        }
        public void HakkindaGuncelle(Hakkinda hakkinda)
        {
            db.Guncelle(hakkinda);
        }
        public List<Hakkinda> HakkindaGetir()
        {
            return db.TumunuGetir();
        }
        public void HakkindaSil(Hakkinda hakkinda)
        {
            db.Sil(hakkinda);
        }






    }
}
