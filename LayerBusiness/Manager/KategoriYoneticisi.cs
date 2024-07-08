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
    public class KategoriYoneticisi : IKategoriServis
    {
        IKategoriDAL db;
        public KategoriYoneticisi(IKategoriDAL kategoriDAL)
        {
            db = kategoriDAL;
        }
        public void KategoriEkle(Kategori kategori) { 
            db.Ekle(kategori);
        }
        public Kategori KategoriGetir(int id)
        {
            return db.Getir(id);
        }
        public Kategori KategoriGetir(Kategori kategori)
        {
            return db.Getir(kategori);
        }
        public void KategoriGuncelle(Kategori kategori)
        {
            db.Guncelle(kategori);
        }
        public List<Kategori> KategoriGetir()
        {
            return db.TumunuGetir();
        }
        public void KategoriSil(Kategori kategori)
        {
            db.Sil(kategori);
        }
    }
}
