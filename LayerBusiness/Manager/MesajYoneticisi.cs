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
    public class MesajYoneticisi : IMesajServis
    {
        IMesajDAL db;
        public MesajYoneticisi(IMesajDAL mesajDAL) {
            db = mesajDAL;
        }
        public void MesajEkle(Mesaj mesaj)
        {
            db.Ekle(mesaj);
        }
        public Mesaj MesajGetir(int id)
        {
            return db.Getir(id);
        }
        public Mesaj MesajGetir(Mesaj mesaj)
        {
            return db.Getir(mesaj);
        }
        public void MesajGuncelle(Mesaj mesaj) {
            db.Guncelle(mesaj);
        }
        public List<Mesaj> MesajGetir()
        {
            return db.TumunuGetir();
        }
        public void MesajSil(Mesaj mesaj)
        {
            db.Sil(mesaj);
        }
    }
}
