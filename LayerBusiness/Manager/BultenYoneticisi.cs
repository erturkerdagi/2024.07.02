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
    public class BultenYoneticisi : IBultenServis
    {
        IBultenDAL db;
        public BultenYoneticisi(IBultenDAL bultenDAL) {
            db = bultenDAL;
        }
        public void BultenKullanicisiEkle(Bulten bulten)
        {
            db.Ekle(bulten);
        }

        public List<Bulten> BultenKullanicilariniGetir()
        {
            return db.TumunuGetir();
        }
        
    }
}
