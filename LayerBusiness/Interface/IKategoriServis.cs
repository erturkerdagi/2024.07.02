using LayerEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerBusiness.Interface
{
    public interface IKategoriServis
    {
        void KategoriEkle(Kategori kategori);
        void KategoriSil(Kategori kategori);
        void KategoriGuncelle(Kategori kategori);
        List<Kategori> KategoriGetir();
        Kategori KategoriGetir(int id);
    }
}
