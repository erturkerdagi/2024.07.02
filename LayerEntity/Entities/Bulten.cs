﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerEntity.Entities
{
    public class Bulten
    {
        [Key]
        public int BultenID { get; set; }
        public string AdSoyad { get; set; }
        public string Email { get; set; }
        public DateTime EklenmeTarihi { get; set; }
    }
}
