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
    public class YorumYoneticisi : IYorumServis
    {
        IYorumDAL db;
        public YorumYoneticisi(IYorumDAL YorumDAL)
        {
            db = YorumDAL;
        }
        public void YorumEkle(Yorum Yorum)
        {
            db.Ekle(Yorum);
        }
        public Yorum YorumGetir(int id)
        {
            return db.Getir(id);
        }
        public Yorum YorumGetir(Yorum Yorum)
        {
            return db.Getir(Yorum);
        }
        public void YorumGuncelle(Yorum Yorum)
        {
            db.Guncelle(Yorum);
        }
        public List<Yorum> YorumGetir()
        {
            return db.TumunuGetir();
        }
        public void YorumSil(Yorum Yorum)
        {
            db.Sil(Yorum);
        }

        public List<Yorum> YaziYorumlariniGetir(int id)
        {
            return db.Getir(y => y.YaziID == id);
        }
    }
}
