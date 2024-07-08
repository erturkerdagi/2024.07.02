using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerEntity.Entities
{
    public class Yazi
    {
        [Key]
        public int YaziID { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public string KucukResim { get; set; }
        public string BuyukResim { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public bool YaziDurumu { get; set; }
        public int KategoriID { get; set; }
        public Kategori Kategori { get; set; }
        public int YazarID { get; set; }
        public int OkunmaSayisi { get; set; }
        public Yazar Yazar { get; set; }
        public List<Yorum> Yorumlar { get; set; }
    }
}
