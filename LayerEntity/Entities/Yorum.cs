using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerEntity.Entities
{
    public class Yorum
    {
        [Key]
        public int YorumID { get; set; }
        public string YorumKullaniciAdi { get; set; }
        public string YorumBasligi { get; set; }
        public string YorumIcerigi { get; set; }
        public bool YorumDurumu { get; set; }
        public int YaziID { get; set; }
        public Yazi Yazi { get; set; }
    }
}
