using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerEntity.Entities
{
    public class Hakkinda
    {
        [Key]
        public int HakkindaID { get; set; }
        public string HakkindaDetay { get; set; }
        public string Resim { get; set; }
        public bool HakkindaDurum { get; set; }
    }
}
