using LayerEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerBusiness.Interface
{
    public interface IHakkindaServis
    {
        void HakkindaEkle(Hakkinda hakkinda);
        void HakkindaSil(Hakkinda hakkinda);
        void HakkindaGuncelle(Hakkinda hakkinda);
        List<Hakkinda> HakkindaGetir();
        Hakkinda HakkindaGetir(int id);
    }
}
