using LayerEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerBusiness.Interface
{
    public interface IYazarServis
    {
        void YazarEkle(Yazar yazar);
        void YazarSil(Yazar yazar);
        void YazarGuncelle(Yazar yazar);
        List<Yazar> YazarGetir();
        Yazar YazarGetir(int id);

    }
}
