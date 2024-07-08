using FluentValidation;
using LayerEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerBusiness.Kurallar
{
    public class MesajKurali : AbstractValidator<Mesaj>
    {
        public MesajKurali() 
        {
            RuleFor(m => m.MesajKullaniciAdi).NotEmpty().WithMessage("Kullanıcı adı boş geçilemez");
            RuleFor(m => m.MesajKullaniciAdi).MinimumLength(5).WithMessage("Kullanıcı adı en az beş karakter olmalıdır");
            RuleFor(m => m.MesajKullaniciAdi).MaximumLength(30).WithMessage("Kullanıcı adı en fazla oturz karakter olmalıdır");
            RuleFor(m => m.MesajKullaniciEposta).EmailAddress().WithMessage("E-mail adresi hatalıdır");
            RuleFor(m => m.Konu).NotEmpty().WithMessage("Konu alanı boş geçilemez");
            RuleFor(m => m.MesajIcerik).NotEmpty().WithMessage("Mesaj alanı boş geçilemez");
        }
    }
}