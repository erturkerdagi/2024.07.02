using LayerEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerBusiness.Interface
{
    public interface IYorumServis
    {
        void YorumEkle(Yorum yorum);
        void YorumSil(Yorum yorum);
        void YorumGuncelle(Yorum yorum);
        List<Yorum> YorumGetir();
        Yorum YorumGetir(int id);
    }
}
