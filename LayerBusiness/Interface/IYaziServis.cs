using LayerEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerBusiness.Interface
{
    public interface IYaziServis
    {
        void YaziEkle(Yazi yazi);
        void YaziSil(Yazi yazi);
        void YaziGuncelle(Yazi yazi);
        List<Yazi> YaziGetir();
        Yazi YaziGetir(int id);
    }
}
