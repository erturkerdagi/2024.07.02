using LayerEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerBusiness.Interface
{
    public interface IMesajServis
    {
        void MesajEkle(Mesaj mesaj);
        void MesajSil(Mesaj mesaj);
        void MesajGuncelle(Mesaj mesaj);
        List<Mesaj> MesajGetir();
        Mesaj MesajGetir(int id);
    }
}
