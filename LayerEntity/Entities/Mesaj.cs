using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerEntity.Entities
{
    public class Mesaj
    {
        [Key]
        public int MesajID { get; set; }
        public string MesajKullaniciAdi { get; set; }
        public string MesajKullaniciEposta { get; set; }
        public string Konu { get; set; }
        public string MesajIcerik { get; set; }
        public DateTime MesajTarihi { get; set; }
        public bool MesajDurumu { get; set; }
    }
}
