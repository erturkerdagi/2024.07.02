﻿using LayerEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerBusiness.Interface
{
    public interface IKullaniciServis
    {
        Kullanicilar KullaniciGetir(Kullanicilar Kullanici);
    }
}