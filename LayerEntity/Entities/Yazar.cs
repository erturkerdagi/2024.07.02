using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerEntity.Entities
{
    public class Yazar
    {
        [Key]
        public int YazarID { get; set; }
        public string YazarAdi{ get; set; }
        public string YazarAciklamasi { get; set; }
        public string YazarResmi { get; set; }
        public string YazarEposta { get; set; }
        public string YazarSifre { get; set; }
        public bool YazarDurumu { get; set; }
        public List<Yazi> Yazilar { get; set; }

    }
}
